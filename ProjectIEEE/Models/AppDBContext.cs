using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection.Emit;

namespace ProjectIEEE.Models
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = QR Code2 ; trustservercertificate = true ; integrated security = SSPI");
            optionsBuilder
            .ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity <Course>()
                .HasOne(X=>X.Doctor)
                .WithMany(l=>l.Courses)
                .HasForeignKey(l=>l.Doctor_id);

            modelBuilder.Entity<Attendance>()
              .HasOne(X => X.Student)
              .WithMany(l => l.Attendances)
              .HasForeignKey(l => l.Student_id);

            modelBuilder.Entity<Attendance>()
              .HasOne(X => X.Course)
              .WithMany(l => l.Attendances)
              .HasForeignKey(l => l.Course_id);

            //base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
        }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Doctor>? Doctors { get; set; } 
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Attendance>? Attendances { get; set; }
    }
} 

