using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectIEEE.Models;

namespace ProjectIEEE.Configurations
{
    public class GeneralConfiguration : IEntityTypeConfiguration<Student>
    {
       public new List<Student> Students = new List<Student>
            {
            new Student {Id=1, Name = "Ali", Email = "ali@example.com" ,Password="300405"},
            new Student {Id=2, Name = "Nada", Email = "nada@example.com",Password="300405" },
            new Student {Id=3, Name = "Omar", Email = "omar@example.com",Password="300405" },
            new Student {Id=4, Name = "Layla", Email = "layla@example.com",Password="300405" },
            new Student {Id=5, Name = "Youssef", Email = "youssef@example.com", Password="300405"},
            new Student {Id=6, Name = "Fatma", Email = "fatma@example.com",Password="300405" },
            new Student {Id=7, Name = "Karim", Email = "karim@example.com",Password="300405" },
            new Student {Id=8, Name = "Salma", Email = "salma@example.com",Password="300405" },
            new Student {Id=9,Name = "Hany", Email = "hany@example.com",Password="300405" },
            new Student {Id=10,Name = "Mariam", Email = "mariam@example.com", Password="300405"}
        };
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(Students);
        }
        // إضافة طلاب (Students)
    }
}

