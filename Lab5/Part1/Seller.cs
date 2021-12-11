using System;

namespace Part1
{
    public class Seller
    {
        private string _sellerName;

        public virtual void ShowSellerMessage(string fromWhom, string message)
        {
            Console.WriteLine($"{fromWhom}> {message}");
        }

        public void Run(string sellerName, string message)
        {
            _sellerName = sellerName;
            ShowSellerMessage(sellerName, message);
        }

        public void Run(string message)
        {
            ShowSellerMessage(_sellerName, message);
        }
    }
}
