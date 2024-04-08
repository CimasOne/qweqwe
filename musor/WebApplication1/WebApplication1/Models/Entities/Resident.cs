namespace WebApplication1.Models.Entities
{
    public class Resident
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate {  get; set; }
        public string Relationship { get; set; }
    }
}
