namespace ProjectIEEE.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string QRcode_Image { get; set; }
        public string QRcode_Link { get; set; }
        public int Doctor_id{  get; set; }
        public Doctor? Doctor { get; set; }
        public ICollection<Attendance>? Attendances { get; set; }
    }
} 

