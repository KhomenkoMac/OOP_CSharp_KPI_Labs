namespace Part1
{
    public class SellerContext
    {
        private Seller _seller;
        public Seller Seller
        {
            set
            {
                _seller = value;
            }
        }

        private string _message;
        public string Message
        {
            set { _message = value; }
        }

        private string _sellerName;
        public string Sellername
        {
            set { _sellerName = value; }
        }

        public void ShowSellersMessage()
        {
            _seller.ShowSellerMessage(_sellerName, _message);
        }
    }
}
