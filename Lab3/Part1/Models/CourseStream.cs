using System.Collections.Generic;

namespace Part1.Models
{
    public class CourseStream : StudAnalyzeComponent // composite(Container, box)
    {
        public string StreamName { get; set; }
        public override string Naming => StreamName;
        public CourseStream(IEnumerable<Group> groups) : base(groups) { }

    }
}
