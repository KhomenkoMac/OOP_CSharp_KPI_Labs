using System;
using System.Collections.Generic;
using System.Linq;

namespace Part1.Models
{
    public class Student : StudAnalyzeComponent // Leaf
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

        public override void Add(StudAnalyzeComponent c)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(StudAnalyzeComponent c)
        {
            throw new InvalidOperationException();
        }
    }
}
