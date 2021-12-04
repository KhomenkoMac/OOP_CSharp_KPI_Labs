using System.Collections.Generic;

namespace Part1.Models
{
    public class Course : StudAnalyzeComponent // composite(Container, box)
    {
        public string CourseName { get; set; }
        public override string Naming => CourseName;

        public Course(IEnumerable<CourseStream> streams) : base(streams) { }
    }
}
