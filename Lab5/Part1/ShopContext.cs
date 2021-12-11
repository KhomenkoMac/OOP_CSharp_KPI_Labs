namespace Part1
{
    public class ShopContext
    {
        //public void SetStrategy(IShop shop)
        //{
        //    _shop = shop;
        //}
        
        private Shop _shop;
        public Shop Shop
        {
            set
            {
                _shop = value;
            }
        }

        //public void SetClient(Client client)
        //{
        //    _client = client;
        //}
        
        private Client _client;
        public Client Client
        {
            set
            {
                _client = value;
            }
        }

        public void DeliverGoods()
        {
            _shop.DeliverGoods(_client.Cart);
        }

        public void GetClientPurchase()
        {
            _shop.GetClientPurchase(_client);
        }

        public void GetMoneyForGoods()
        {
            _shop.GetMoneyForGoods(_client);
        }

        public void GreetCameClient()
        {
            _shop.GreetCameClient(_client);
        }

        public void ShowAdressInfo()
        {
            _shop.ShowAdressInfo();
        }

        public void ShowGoods()
        {
            _shop.ShowGoods();
        }
    }
}
