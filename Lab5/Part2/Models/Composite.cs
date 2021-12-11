using System;
using System.Collections.Generic;

namespace Part2.Models
{

    #region Composite Elements
    // implmenting composite pattern
    public abstract class SocialComponent
    {
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual bool WantToVisitShow { get; set; }


        public abstract void Add(SocialComponent composite);
        public abstract void Remove(SocialComponent composite);
        public abstract void Accept(IVisitor visitor);

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }

    public class Composite: SocialComponent
    {
        private ICollection<SocialComponent> _components = new List<SocialComponent>();

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var item in _components)
            {
                item.Accept(visitor);
            }
        }

        public override void Add(SocialComponent comp)
        {
            _components.Add(comp);
        }

        public override void Remove(SocialComponent comp)
        {
            _components.Remove(comp);
        }
    }

    public class Person: SocialComponent
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override void Add(SocialComponent composite)
        {
            throw new InvalidOperationException();
        }
        public override void Remove(SocialComponent composite)
        {
            throw new InvalidOperationException();
        }
    }

    #endregion

    // defining where we can visit at all
    public interface IVisitor
    {
        void Visit(Person person);
        void Visit(Composite composite);
    }

    public class DesireOfShowVisitor : IVisitor
    {
        public ICollection<SocialComponent> PersonsHavingDesire { get; private set; } = new List<SocialComponent>();

        public void Visit(Composite composite)
        {
            if (composite.WantToVisitShow)
            {
                PersonsHavingDesire.Add(composite);
            }
        }

        public void Visit(Person person)
        {
            if (person.WantToVisitShow)
            {
                PersonsHavingDesire.Add(person);
            }
        }
    }
}
