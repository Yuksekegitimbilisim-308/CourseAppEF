using CourseAppEF.Context;
using CourseAppEF.Entities;
using CourseAppEF.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CourseAppEF.Repository
{
    public class StudentRepository
    {
        AppDbContext db;
        public StudentRepository()
        {
            db = new AppDbContext();
        }
        public Student GetStudentById(int id)
        {
            return db.Students.FirstOrDefault(x => x.Id == id);
        }
        public List<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }
        public List<StudentWithGrade> GetAllStudentWithGrades()
        {
            var list = db.Students.Include("Grade").Select(x => new StudentWithGrade
            {
                Id = x.Id,
                Fullname = x.Fullname,
                IsActive = x.IsActive,
                PhoneNumber = x.PhoneNumber,
                LessonName = x.Grade.Derslik
            }).ToList();
            return list;
        }
        public List<StudentWithGrade> GetAllStudentWithGradesByFullname(string searchTerm)
        {
            List<StudentWithGrade> list = db.Students.Include("Grade").Select(x => new StudentWithGrade
            {
                Id = x.Id,
                Fullname = x.Fullname,
                IsActive = x.IsActive,
                PhoneNumber = x.PhoneNumber,
                LessonName = x.Grade.Derslik
            }).Where(x => x.Fullname.StartsWith(searchTerm))
               .OrderBy(x => x.Fullname)
               .ToList();
            return list;
        }
        public void AddStudent(Student Student)
        {
            db.Students.Add(Student);
            db.SaveChanges();
        }
        public void UpdateStudent(Student Student)
        {
            var entity = db.Students.FirstOrDefault(x => x.Id == Student.Id);
            entity.Fullname = Student.Fullname;
            entity.PhoneNumber = Student.PhoneNumber;
            entity.IsActive = Student.IsActive;
            entity.GradeId = Student.GradeId;
            db.SaveChanges();

        }
        public void DeleteStudent(int id)
        {
            var Student = GetStudentById(id);
            db.Students.Remove(Student);
            db.SaveChanges();
        }
    }
}
