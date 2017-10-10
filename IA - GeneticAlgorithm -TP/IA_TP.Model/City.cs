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

        public double GetDistanceTo(City otherCity)
        {
            double distance = Math.Sqrt(Math.Pow(this.Latitude - otherCity.Latitude, 2) + Math.Pow(this.Longitude - otherCity.Longitude, 2));
            
            return distance;
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

        //public double CalculateAssessment(TelcoSur telcosSur, List<City> cities)
        //{
        //    double shortestDistance = this.FindShortestDistance(cities);
        //    telcosSur.FiberChannelKmsInUse += shortestDistance;

        //    double cost = shortestDistance * telcosSur.FiberChannelKmCost;

        //    double tvEarnings = (this.Demand.TV * telcosSur.Catalogue.TV_Price);
        //    double phoneEarnings = (this.Demand.Phone * telcosSur.Catalogue.Phone_Price);
        //    double internetEarnings = (this.Demand.Internet * telcosSur.Catalogue.Internet_Price);

        //    double earnings = tvEarnings + phoneEarnings + internetEarnings;            

        //    return earnings - cost;
        //}

        private double FindShortestDistance(List<City> otherCities)
        {
            double shortestDistance = 999999;
            foreach (var city in otherCities)
            {
                //if it is the same city, we should continue.
                if (city.Name == this.Name)
                    continue;
                
                double distance = this.GetDistanceTo(city);
                if (distance < shortestDistance)
                    shortestDistance = distance;
            }

            return shortestDistance;
        }

        public double CalculateEarnings(TelcoSur telcoSur)
        {
            double tvEarnings = (this.Demand.TV * telcoSur.Catalogue.TV_Price);
            double phoneEarnings = (this.Demand.Phone * telcoSur.Catalogue.Phone_Price);
            double internetEarnings = (this.Demand.Internet * telcoSur.Catalogue.Internet_Price);

            return tvEarnings + phoneEarnings + internetEarnings;
        }
    }
}
