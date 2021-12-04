using System.Collections.Generic;

namespace Part1.Models
{
    public class Group : StudAnalyzeComponent // composite(Container, box)
    {
        public string GroupName { get; set; }
        public override string Naming => GroupName;
        public Group(IEnumerable<StudAnalyzeComponent> students) : base(students) { }
    }
}
