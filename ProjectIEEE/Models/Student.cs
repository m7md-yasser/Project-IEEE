using System.ComponentModel;

namespace ProjectIEEE.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        public int Std_id { get; set; }
        public string Name { get; set; }
        public int level { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }
        public ICollection<Attendance>? Attendances { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Email} {this.Id}";
        }
    }
} 

