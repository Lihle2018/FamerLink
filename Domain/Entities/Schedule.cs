
namespace Domain.Entities
{
    /// <summary>
    /// represents a schedule for a vendor, with the day of the week and the start and end times of their business hours. The VendorId property and navigation property allow the schedule to be associated with a specific vendor in the system
    /// </summary>
    public sealed class Schedule
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
