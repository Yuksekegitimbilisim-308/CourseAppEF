using CourseAppEF.Context;
using CourseAppEF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CourseAppEF.Repository
{
    public class GradeRepository
    {
        //CRUD
        AppDbContext db;
        public GradeRepository()
        {
            db = new AppDbContext();
        }
        public Grade GetGradeById(int id)
        {
            return db.Grades.FirstOrDefault(x => x.Id == id);
        }
        public List<Grade> GetAllGrades()
        {
            return db.Grades.ToList();
        }
        public void AddGrade(Grade grade)
        {
            db.Grades.Add(grade);
            db.SaveChanges();
        }
        public void UpdateGrade(Grade grade)
        {
            var entity = db.Grades.FirstOrDefault(x => x.Id == grade.Id);
            entity.Derslik = grade.Derslik;
            db.SaveChanges();

        }
        public void DeleteGrade(int id)
        {
            var grade = GetGradeById(id);
            db.Grades.Remove(grade);
            db.SaveChanges();
        }

    }
}
