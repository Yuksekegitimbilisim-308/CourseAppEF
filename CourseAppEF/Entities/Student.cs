namespace CourseAppEF.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public Grade Grade { get; set; }
        public int GradeId { get; set; }
    }
}
