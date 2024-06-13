namespace Solid.Core.Entities
{
    public class Turn
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double SumHour { get; set; }
        public string Type { get; set; }
        public string NameServiceProvider { get; set; }
        public int ServiceProvidersId { get; set; }
        public ServiceProviders ServiceProviders { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
