using System;
using System.Collections.Generic;
using System.Linq;

namespace Part1.Models
{
    public class Faculty : Component
    {
        public string FacultyName { get; set; }
        public override string Naming => FacultyName;

        public Faculty(IEnumerable<Course> courses) : base(courses)
        {
            this.Components = courses;
        }
    }

    public class Course : Component
    {
        public string CourseName { get; set; }
        public override string Naming => CourseName;

        public Course(IEnumerable<CourseStream> streams) : base(streams) { }
    }

    public class CourseStream : Component
    {
        public string StreamName { get; set; }
        public override string Naming => StreamName;
        public CourseStream(IEnumerable<Group> groups) : base(groups) { }

    }

    public class Group : Component
    {
        public string GroupName { get; set; }
        public override string Naming => GroupName;
        public Group(IEnumerable<Component> students) : base(students) { }
    }

    public class Student : Component
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public override string Naming => $"{Firstname} {Middlename} {Lastname}";

        public IEnumerable<double> Grades { get; set; }

        public Student() : base(null) { }

        public override double Avg()
        {
            return Grades.Average(g => g);
        }

        public override void Display(int ident)
        {
            string str = "";
            foreach (var item in Grades)
            {
                str += $"{item} ";
                
            }
            Console.WriteLine($"{new String(' ', ident)}Grades: {str}");
        }

        public override void Add(Component c)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(Component c)
        {
            throw new InvalidOperationException();
        }
    }
}
