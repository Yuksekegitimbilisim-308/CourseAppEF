using System.Collections;
using System.Collections.Generic;

namespace CourseAppEF.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public string Derslik { get; set; }
        public List<Student> Students{ get; set; }
    }
}
// TODO:
