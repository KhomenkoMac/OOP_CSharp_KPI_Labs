using System;

namespace Part1
{
    public class Good
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}; {nameof(Name)}: {Name}; {nameof(Price)}: {Price};";
        }
    }
}
