namespace ProjectIEEE.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public int Doc_id { get; set; }
        public string Name { get; set; }
        public string email {  get; set; }
        public string password {  get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}

