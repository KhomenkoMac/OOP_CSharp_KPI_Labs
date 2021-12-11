using System;

namespace Part1
{
    public class WebPage : Seller
    {
        public override void ShowSellerMessage(string sellerName, string message)
        {
            Console.Write($"{nameof(WebPage)} ");
            base.ShowSellerMessage(sellerName, message);
        }
    }
}
