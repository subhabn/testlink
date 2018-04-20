using Microsoft.EntityFrameworkCore;

namespace BL.Link.Models
{
    public class DBTestContext : DbContext
    {
        public DBTestContext(DbContextOptions<DBTestContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
//                entity.Property((e=>e.Email).)
//                entity.Property(e => e.Address1).HasColumnType("varchar(50)");
//                entity.Property(e => e.Address2).HasColumnType("varchar(50)");
//                entity.Property(e => e.City).HasColumnType("varchar(30)");
//                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
//                entity.Property(e => e.DateOfRegistration).HasColumnType("datetime");
//                entity.Property(e => e.Email).HasColumnType("varchar(50)");
//                entity.Property(e => e.FirstName).HasColumnType("varchar(30)");
//                entity.Property(e => e.Gender).HasColumnType("varchar(10)");
//                entity.Property(e => e.LastName).HasColumnType("varchar(30)");
//                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(20)");
//                entity.Property(e => e.State).HasColumnType("varchar(30)");
//                entity.Property(e => e.Zip).HasColumnType("nchar(10)");
            });
        }

        public DbSet<User> Users { get; set; }
    }
}