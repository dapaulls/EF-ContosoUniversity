namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        /*
         * Entity Framework interprets a property as a foreign key property if it's 
         * named <navigation property name><primary key property name>
         * (for example, StudentID for the Student navigation property since the 
         * Student entity's primary key is ID).
         * Foreign key properties can also be named the same simply <primary key property name>
         * (for example, CourseID since the Course entity's primary key is CourseID).
         */
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        // An Enrollment entity is associated with one Course entity.
        public virtual Course Course { get; set; }
        
        // An Enrollment entity is associated with one Student entity. 
        public virtual Student Student { get; set; }
    }
}