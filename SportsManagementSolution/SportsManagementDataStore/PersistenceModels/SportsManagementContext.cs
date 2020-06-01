using Microsoft.EntityFrameworkCore;

namespace SportsManagement.PersistenceModels
{
    public partial class SportsManagementContext : DbContext
    {
        public SportsManagementContext()
        {
        }

        public SportsManagementContext(DbContextOptions<SportsManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SportsPersons> SportsPersons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<SportsPersons>(entity =>
            {
                entity.Property(e => e.AssociatedSports)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GravatarUrl).HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOnUtc).HasColumnType("datetime");
            });
        }
    }
}
