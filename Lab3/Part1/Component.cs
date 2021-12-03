using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public abstract class Component
    {
        protected double ComponentsAverage = 0;

        public virtual double Avg()
        {
            throw new NotImplementedException();
        }

        public virtual string Display()
        {
            throw new NotImplementedException();
        }
    }
}
