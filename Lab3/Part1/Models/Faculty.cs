using System.Collections.Generic;

namespace Part1.Models
{
    public class Faculty : StudAnalyzeComponent // composite(Container, box)
    {
        public string FacultyName { get; set; }
        public override string Naming => FacultyName;

        public Faculty(IEnumerable<Course> courses) : base(courses)
        {
            this.Components = courses;
        }
    }
}
