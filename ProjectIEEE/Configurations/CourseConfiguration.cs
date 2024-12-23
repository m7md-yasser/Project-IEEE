using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectIEEE.Models;

namespace ProjectIEEE.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        // إضافة مواد (Courses)
        public new List<Course> Courses = new List<Course>
            {
            new Course {Id=1, Name = "Mathematics", Doctor_id = 1 , QRcode_Image ="3.jpg", QRcode_Link ="----"},
            new Course {Id=2, Name = "Physics", Doctor_id = 2, QRcode_Image ="2.jpg", QRcode_Link ="----"},
            new Course {Id=3, Name = "Chemistry", Doctor_id =3 , QRcode_Image ="5.jpg", QRcode_Link ="----"},
            new Course {Id=4, Name = "Programming", Doctor_id = 4, QRcode_Image ="1.jpg", QRcode_Link ="---" },
            new Course {Id=5, Name = "Biology", Doctor_id = 4, QRcode_Image ="4.jpg", QRcode_Link ="-----"}
            };
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(Courses);
        }
    }
}

