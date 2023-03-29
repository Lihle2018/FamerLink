namespace Domain.Interfaces.Repositories
{
    public interface ILocationRepository : IRepository<Location>
    {
        IEnumerable<Location> GetByGeoLocation(GeoLocation geoLocation);
    }

}
