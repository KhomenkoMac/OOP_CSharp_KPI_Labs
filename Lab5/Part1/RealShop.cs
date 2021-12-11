using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
            sellerContext = new();
            sellerContext.Seller = new Cashier();

            var goodsList = Avaliable_goods.ToList();
            for (int i = 0; i < goodsList.Count; i++)
            {
                sellerContext.Message = $"{i + 1} - {goodsList[i]}";
                sellerContext.ShowSellersMessage();
            }
        }
    }
}
