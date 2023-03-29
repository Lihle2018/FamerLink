namespace Domain.Interfaces.Services
{
    public interface IMapService
    {
        Location GetLocation(Address address);
        IEnumerable<Location> GetNearbyLocations(Location location, int radius);
    }
}
