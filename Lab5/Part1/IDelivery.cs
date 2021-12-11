using System.Collections.Generic;

namespace Part1
{
    public interface IDelivery
    {
        void Deliver(ICollection<Good> goods);
    }
}
