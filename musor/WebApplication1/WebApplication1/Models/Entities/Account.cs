namespace WebApplication1.Models.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start => DateTime.Now;
        public DateTime? End => DateTime.Now;
        public string Address { get; set; }
        public decimal Area { get; set; }
        
    }
}
