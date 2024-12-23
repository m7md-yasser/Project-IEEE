using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectIEEE.Models;

namespace ProjectIEEE.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        // إضافة دكاترة (Doctors)
        public new List<Doctor> doctors = new List<Doctor>
            {
            new Doctor {password="300405", Id=1,Name = "Dr. Ahmed", email = "ahmed@example.com" },
            new Doctor {password="300504", Id=2,Name = "Dr. Sara", email = "sara@example.com" },
            new Doctor {password="300546", Id=3,Name = "Dr. Khaled", email = "khaled@example.com" },
            new Doctor {password="300467", Id=4,Name = "Dr. Mona", email = "mona@example.com" }
            };
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(doctors);
        }
    }
}

