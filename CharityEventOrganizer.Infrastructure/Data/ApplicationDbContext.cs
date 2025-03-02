using CharityEventOrganizer.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CharityEventOrganizer.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventSubmission> EventSubmissions { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<EventSponsor> EventSponsors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure ApplicationUser to EventSubmission relationship
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.EventSubmissions)
                .WithOne(s => s.Submitter)
                .HasForeignKey(s => s.SubmitterId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configure Admin to EventSubmission relationship
            modelBuilder.Entity<EventSubmission>()
                .HasOne(s => s.Admin)
                .WithMany() // Admin doesn't have a navigation property back to EventSubmissions
                .HasForeignKey(s => s.AdminId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configure the EventSponsor as a many-to-many relationship
            modelBuilder.Entity<EventSponsor>()
                .HasKey(es => new { es.EventId, es.SponsorId });

            modelBuilder.Entity<EventSponsor>()
                .HasOne(es => es.Event)
                .WithMany(e => e.EventSponsors)
                .HasForeignKey(es => es.EventId);

            modelBuilder.Entity<EventSponsor>()
                .HasOne(es => es.Sponsor)
                .WithMany(s => s.SponsoredEvents)
                .HasForeignKey(es => es.SponsorId);

            // Configure one-to-one relationship between Event and EventSubmission
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Submission)
                .WithOne(s => s.Event)
                .HasForeignKey<EventSubmission>(s => s.EventId);

            // Configure other relationships and constraints
            modelBuilder.Entity<Event>()
                .Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Event>()
                .Property(e => e.Description)
                .IsRequired();

            modelBuilder.Entity<Sponsor>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Sponsor>()
                .Property(s => s.ContactEmail)
                .IsRequired();
        }
    }
}