namespace Solid.Core.Entities
{
    public class ServiceProviders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DayWork { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Turn> Turns { get; set; }
    }
}
