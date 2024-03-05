using System.ComponentModel.DataAnnotations;

namespace OccupationalSpecialism_Pet_Care_Platform.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileLocation { get; set; }
        public int UserId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime UploadedAt { get; set; }
    }
}
