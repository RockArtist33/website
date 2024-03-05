using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OccupationalSpecialism_Pet_Care_Platform.Models;

namespace OccupationalSpecialism_Pet_Care_Platform.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.GenericArticle> GenericArticle { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.Attachment> Attachments { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.Booking> Bookings { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.Group> Groups { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.Message> Messages { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.MessageGroup> MessageGroups { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.Pet> Pets { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.Service> Services { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.UserGroup> UserGroups { get; set; } = default!;
        public DbSet<OccupationalSpecialism_Pet_Care_Platform.Models.UserPet> UserPets { get; set; } = default!;
    }
}