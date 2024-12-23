using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectIEEE.Models;

namespace ProjectIEEE.Configurations
{
    public class AttendenceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public new List<Attendance> Attendances = new List<Attendance>
            {
            new Attendance { Id=1,Student_id = 1, Course_id = 1,Attend_count =3 ,Attend_Max=8, AttendanceDate = DateTime.Now},
            new Attendance { Id=2,Student_id = 2, Course_id = 1,Attend_count =4,Attend_Max=8, AttendanceDate = DateTime.Now },
            new Attendance { Id=3,Student_id = 3, Course_id = 2, Attend_count = 6,Attend_Max=10, AttendanceDate = DateTime.Now  },
            new Attendance { Id=4,Student_id = 4, Course_id = 3,Attend_count = 7, Attend_Max=10, AttendanceDate = DateTime.Now  }
            };
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasData(Attendances);
        }
    }
}

