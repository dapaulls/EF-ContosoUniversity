using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // By default, the Entity Framework interprets a property that's named ID or classnameID as the primary key. 
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        /* 
         * Navigation properties hold other entities that are related to this entity.
         * Navigation properties are typically defined as virtual so that they can take
         * advantage of certain Entity Framework functionality such as lazy loading.
         * 
         * If a navigation property can hold multiple entities (as in many-to-many or one-to-many relationships),
         * its type must be a list in which entries can be added, deleted, and updated, such as ICollection.
         */  
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}