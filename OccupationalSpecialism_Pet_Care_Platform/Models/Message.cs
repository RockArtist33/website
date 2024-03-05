using System.ComponentModel.DataAnnotations;

namespace OccupationalSpecialism_Pet_Care_Platform.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string UserId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime SentAt { get; set; }
        public int AttachmentId { get; set; }

    }
}
