using System.Collections.Generic;
using System.Linq;

namespace Part1.Models
{
    public class Faculty : Component
    {
        public string FacultyName { get; set; }
        public IEnumerable<Course> Courses { get; set; }

        public override double Avg()
        {
            foreach (var item in Courses)
            {
                ComponentsAverage += item.Avg();
            }

            return ComponentsAverage / Courses.Count();
        }
    }

    public class Course : Component
    {
        public string CourseName { get; set; }
        public IEnumerable<CourseStream> Streams { get; set; }

        public override double Avg()
        {
            foreach (var item in Streams)
            {
                ComponentsAverage += item.Avg();
            }

            return ComponentsAverage / Streams.Count();
        }
    }

    public class CourseStream : Component
    {
        public string StreamName { get; set; }
        public IEnumerable<Group> Groups { get; set; }

        public override double Avg()
        {
            foreach (var item in Groups)
            {
                ComponentsAverage += item.Avg();
            }

            return ComponentsAverage / Groups.Count();
        }
    }

    public class Group: Component
    {
        public string GroupName { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public override double Avg()
        {
            foreach (var item in Students)
            {
                ComponentsAverage += item.Avg();
            }

            return ComponentsAverage / Students.Count();
        }
    }

    public class Student : Component
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public IEnumerable<double> Grades { get; set; }

        public override double Avg()
        {
            return Grades.Average(g => g);
        }
    }
}
