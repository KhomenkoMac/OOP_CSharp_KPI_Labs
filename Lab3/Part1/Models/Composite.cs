using System.Collections.Generic;

namespace Part1.Models
{
    public class Composite : StudAnalyzeComponent
    {
        public Composite(IEnumerable<StudAnalyzeComponent> components): base(components) { }
    }
}
