using System;
using System.Collections.Generic;
using System.Linq;

namespace Part1
{
    public abstract class Component
    {
        protected double ComponentsAverage = 0;

        protected IEnumerable<Component> Components;

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
            foreach (var item in Components)
            {
                ComponentsAverage += item.Avg();
            }
            return ComponentsAverage / Components.Count();
        }

        public virtual void Display(int ident)
        {
            throw new NotImplementedException();
        }
    }
}
