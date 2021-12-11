using System;
using System.Collections.Generic;
using System.Threading;

namespace Part1
{
    public class CourierDelivery : IDelivery
    {
        public void Deliver(ICollection<Good> goods)
        {
            Console.WriteLine("Ding dong... This is courier!");
            Thread.Sleep(1000);

            Console.WriteLine("Your signature!");
            Thread.Sleep(1000);

            Console.WriteLine("Unpacking....");
            Thread.Sleep(1000);

            foreach (var item in goods)
            {
                Console.WriteLine(item);
            }
        }
    }
}
