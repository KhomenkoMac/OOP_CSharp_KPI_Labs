using System.Collections.Generic;

namespace Part1
{
    public class DeliveryContext
    {
        private IDelivery _delivery;
        public IDelivery Delivery
        {
            set { _delivery = value; }
        }


        private ICollection<Good> _goods;

        public ICollection<Good> Goods
        {
            set { _goods = value; }
        }

        public void Deliver()
        {
            _delivery.Deliver(_goods);
        }
    }
}
