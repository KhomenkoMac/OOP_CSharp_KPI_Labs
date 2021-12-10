using System;
using System.Collections.Generic;
using System.Linq;

namespace Part1
{
    public abstract class StudAnalyzeComponent // component defines general operations for simple and complex objects
    {
        protected double ComponentsAverage = 0;

        protected IEnumerable<StudAnalyzeComponent> Components;

        public virtual string Naming { get; set; }

        public StudAnalyzeComponent(IEnumerable<StudAnalyzeComponent> components)
        {
            Components = components;
        }

        public virtual void Add(StudAnalyzeComponent c)
        {
            Components.ToList().Add(c);
        }

        public virtual void Remove(StudAnalyzeComponent c)
        {
            Components.ToList().Remove(c);
        }

        public virtual double Avg()
        {
            ComponentsAverage = 0;
            foreach (var item in Components)
            {
                ComponentsAverage += item.Avg();
            }
            return ComponentsAverage / Components.Count();
        }

        public virtual void Display(int ident)
        {
            ident += 3;
            foreach (var item in Components)
            {
                Console.WriteLine($"{new String(' ', ident)}{item.Naming} - {item.Avg():f2}");
                item.Display(ident);
                Console.WriteLine();
            }
        }
    }
}
