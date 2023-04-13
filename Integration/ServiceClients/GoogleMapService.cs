namespace Integration.ServiceClients
{
    public class GoogleMapService : IMapService
    {
        public Task<Location> GetLocationAsync(Address address)
        {
            
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> GetNearbyLocationsAsync(Location location, int radius)
        {
            throw new NotImplementedException();
        }
    }
}
