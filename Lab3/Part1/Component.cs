using System;
using System.Collections.Generic;
using System.Linq;

namespace Part1
{
    public abstract class Component
    {
        protected double ComponentsAverage = 0;

        protected IEnumerable<Component> Components;

        public virtual string Naming => "undefined";

        public Component(IEnumerable<Component> components)
        {
            Components = components;
        }

        public virtual void Add(Component c)
        {
            Components.ToList().Add(c);
        }

        public virtual void Remove(Component c)
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
