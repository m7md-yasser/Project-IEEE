namespace ProjectIEEE.Models
{
    public class Attendance
        {
        public int Id { get; set; }
        public int Course_id { get; set; }
        public Course Course { get; set; }
        public int Student_id { get; set; }
        public Student Student { get; set; }
        public int Attend_count { get; set; }
        public int Attend_Max { get; set; }
        public DateTime? AttendanceDate { get; set; }
    }
} 

