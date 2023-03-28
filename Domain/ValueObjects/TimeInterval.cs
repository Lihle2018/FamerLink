using Domain.ValueObjects;

public class TimeInterval : ValueObject<TimeInterval>
{
    public DateTime StartTime { get; }
    public DateTime EndTime { get; }

    public TimeInterval(DateTime startTime, DateTime endTime)
    {
        StartTime = startTime;
        EndTime = endTime;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return StartTime;
        yield return EndTime;
    }
}