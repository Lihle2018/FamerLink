namespace Domain.Interfaces.Services
{
    public interface IMapService
    {
        Task<Location> GetLocationAsync(Address address);
        Task<IEnumerable<Location>> GetNearbyLocationsAsync(Location location, int radius);
    }
}
