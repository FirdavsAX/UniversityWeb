using Microsoft.EntityFrameworkCore;
using UniversityWeb.Entities;

namespace UniversityWeb.Data
{
    public class UniversityWebDbContext:DbContext
    {
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Department> Departments{ get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseAssignment> CourseAssignments{ get; set; }
        public virtual DbSet<Student> Students{ get; set; }
        public virtual DbSet<Enrollment> Enrollments{ get; set; }
        public UniversityWebDbContext(DbContextOptions<UniversityWebDbContext>options ):base(options)
        {
            
        }
    }
}
