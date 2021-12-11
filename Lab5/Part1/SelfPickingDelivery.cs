using System;
using System.Collections.Generic;
using System.Threading;

namespace Part1
{
    public class SelfPickingDelivery : IDelivery
    {
        public void Deliver(ICollection<Good> goods)
        {
            Console.WriteLine("Walking from shop...");
            Thread.Sleep(4000);

            Console.WriteLine("Unpacking....");
            Thread.Sleep(1000);

            foreach (var item in goods)
            {
                Console.WriteLine(item);
            }
        }
    }
}
