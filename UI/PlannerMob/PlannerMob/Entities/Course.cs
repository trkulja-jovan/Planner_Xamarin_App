using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerMob.Entities
{
 
    //Probna klasa koja predstavlja jedan predmet
    //Ima ID i Naziv (npr)
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        private Course(int courseId, string courseName)
        {
            this.CourseID = courseId;
            this.CourseName = courseName;
        }

        public static Course CreateCourse(int courseId, string courseName) => new Course(courseId, courseName);

        public override string ToString() => this.CourseName;
    }
}
