namespace Domain.Entities
{
    public class DeliveryWindow
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Duration => End - Start;
        public bool IsValid => End >= Start;
    }

}
