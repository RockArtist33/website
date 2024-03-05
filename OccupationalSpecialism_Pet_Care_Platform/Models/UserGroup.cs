namespace OccupationalSpecialism_Pet_Care_Platform.Models
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int GroupId { get; set; }
        public int HasAdmin { get; set; }
    }
}
