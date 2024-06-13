namespace Solid.API.Entites
{
    public class TurnPostEntite
    {
        public DateTime Date { get; set; }
        public double SumHour { get; set; }
        public string Type { get; set; }
        public string NameServiceProvider { get; set; }
        public int ServiceProvidersId { get; set; }
        public int CustomerId { get; set; }
    }
}
