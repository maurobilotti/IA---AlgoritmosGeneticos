namespace IA_TP.Model
{
    public class City
    {
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

    }
}
