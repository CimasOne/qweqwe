using System;

namespace Person.Models
{
    public class EntitiesModel
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public DateTime Start => DateTime.Now;
        public DateTime? End => DateTime.Now;
        public string Address { get; set; }
        public decimal Area { get; set; }

    }
}
