using System;

namespace Part1
{
    public class Cashier : Seller
    {
        public override void ShowSellerMessage(string sellerName, string message)
        {
            Console.Write($"{nameof(Cashier)} ");
            base.ShowSellerMessage(sellerName, message);
        }
    }
}
