namespace Infrastructure.Data.Repositories
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(FarmLinkDbContext context) : base(context)
        {
        }

        public IEnumerable<Location> GetByGeoLocation(GeoLocation geoLocation)
        {
            return _context.Locations.Where(l => l.GeoLocation.Equals(geoLocation));
        }
    }
}
