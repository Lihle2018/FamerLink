namespace Domain.ValueObjects
{
    [Serializable]
    public class GeoLocation : ValueObject<GeoLocation>
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public GeoLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public GeoLocation()
        {
            // Empty constructor needed for EF Core to work properly
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Latitude;
            yield return Longitude;
        }
    }

}
