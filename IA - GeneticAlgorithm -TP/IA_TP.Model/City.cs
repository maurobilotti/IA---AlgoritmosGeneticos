using System;
using System.Collections.Generic;

namespace IA_TP.Model
{
    public class City
    {
        public City()
        {
            this.Demand = new UserDemand();
        }

        public string Name { get; set; }
        /// <summary>
        /// X
        /// </summary>
        public int Latitude { get; set; }
        /// <summary>
        /// Y
        /// </summary>
        public int Longitude { get; set; }

        public UserDemand Demand { get; set; }

        public int GetDistanceTo(City otherCity)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Latitude.GetHashCode();
                hashCode = (hashCode * 397) ^ Longitude.GetHashCode();
                return hashCode;
            }
        }

        public override bool Equals(object obj)
        {
            var item = obj as City;
            return Equals(item);
        }

        protected bool Equals(City other)
        {
            return string.Equals(Name, other.Name) && Latitude.Equals(other.Latitude) && Longitude.Equals(other.Longitude);
        }

        public double CalculateAssessment(TelcoSur telcosSur)
        {
            double shortestDistance = this.FindShortestDistance(telcosSur.Cities);
            double cost = shortestDistance * telcosSur.FiberChannelKmCost;

            double tvEarnings = (this.Demand.TV * telcosSur.Catalogue.TV_Price);
            double phoneEarnings = (this.Demand.Phone * telcosSur.Catalogue.Phone_Price);
            double internetEarnings = (this.Demand.Internet * telcosSur.Catalogue.Internet_Price);

            double earnings = tvEarnings + phoneEarnings + internetEarnings;

            return earnings - cost;
        }

        private double FindShortestDistance(List<City> otherCities)
        {
            double shortestDistance = 999999;
            foreach (var city in otherCities)
            {
                //if it is the same city, we should continue.
                if (city.Name == this.Name)
                    continue;
                
                double distance = Math.Sqrt(Math.Pow(this.Latitude - city.Latitude, 2) + Math.Pow(this.Longitude - city.Longitude, 2));
                if (distance < shortestDistance)
                    shortestDistance = distance;
            }

            return shortestDistance;
        }
    }
}
