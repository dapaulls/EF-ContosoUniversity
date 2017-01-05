using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        /* 
         * The name of the connection string is passed in to the constructor.
         * If you don't specify a connection string or the name of one explicitly,
         * Entity Framework assumes that the connection string name is the same as the class name.
         */ 
        public SchoolContext() : base("SchoolContext")
        {
        }

        // An entity set typically corresponds to a database table, and an entity corresponds to a row in the table.
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}