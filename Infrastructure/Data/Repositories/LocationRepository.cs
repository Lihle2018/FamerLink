using Domain.Entities;
using Domain.Interfaces;
using Domain.ValueObjects;
using FarmLink.Infrastructure.Data;


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
