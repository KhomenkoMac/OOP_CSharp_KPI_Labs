using System;

namespace Part1
{
    public class Seller
    {
        public virtual void ShowSellerMessage(string fromWhom, string message)
        {
            Console.WriteLine($"{fromWhom}> {message}");
        }
    }
}
