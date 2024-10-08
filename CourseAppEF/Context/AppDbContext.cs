using CourseAppEF.Entities;
using System.Data.Entity;

namespace CourseAppEF.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Server=DESKTOP-OBCSS28;Database=CourseAppDb;User Id=sa;Password=1234;")
        {
            //ORM
            //Object Relational Mapper
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasKey(x => x.Id);
            modelBuilder.Entity<Grade>().Property(x => x.Derslik).HasColumnName("LessonName");
            modelBuilder.Entity<Grade>().Property(x => x.Derslik).HasMaxLength(500);
            //modelBuilder.Entity<Grade>().HasMany(x => x.Students).WithOptional(x => x.Grade).HasForeignKey(x => x.GradeId);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }


    }
}
