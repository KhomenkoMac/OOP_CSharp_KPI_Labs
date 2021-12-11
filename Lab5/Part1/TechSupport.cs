using System;

namespace Part1
{
    public class TechSupport : Seller
    {
        public override void ShowSellerMessage(string sellerName, string message)
        {
            Console.Write($"{nameof(TechSupport)} ");
            base.ShowSellerMessage(sellerName, message);
        }
    }
}
