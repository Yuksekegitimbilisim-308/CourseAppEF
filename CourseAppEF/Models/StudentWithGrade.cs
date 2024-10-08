using System.ComponentModel.DataAnnotations;

namespace CourseAppEF.Models
{
    public class StudentWithGrade
    {
        
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public string LessonName { get; set; }
    }
}
