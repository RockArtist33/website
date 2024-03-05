using System.ComponentModel.DataAnnotations;

namespace OccupationalSpecialism_Pet_Care_Platform.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
    }
}
