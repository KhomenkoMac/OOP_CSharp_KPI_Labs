using System.Linq;

namespace Part1
{
    public class RealShop : Shop
    {
        public RealShop(): base("Kyiv Bulvard Depo-24A 'Music Shop'") 
        {
            ShopType = "real";
        }

        public override void ShowGoods()
        {
            seller = new Cashier();

            var goodsList = Avaliable_goods.ToList();
            for (int i = 0; i < goodsList.Count; i++)
            {
                seller.Run($"{i + 1} - {goodsList[i]}");
            }
        }
    }
}
