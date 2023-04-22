namespace Domain.ValueObjects
{
    [Serializable]
    [Owned]
    public class TimeInterval : ValueObject<TimeInterval>
    {
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public TimeInterval(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }
        public TimeInterval()
        {
            // Empty constructor needed for EF Core to work properly
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return StartTime;
            yield return EndTime;
        }
    }
}
