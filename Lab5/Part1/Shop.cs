using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Part1
{
    public abstract class Shop
    {
        protected SellerContext sellerContext;

        protected enum DeliveryWay
        {
            Courier = 1, SelfPicking
        }
        protected enum PaymentWays
        {
            Card = 1, Cash
        }

        protected readonly string Adresss;
        protected string ShopType;

        private ICollection<Good> _avaliable_goods = new List<Good>
        {
            new Good() { Id = Guid.NewGuid(), Name = "Ssd drive", Price = 700 },
            new Good() { Id = Guid.NewGuid(), Name = "Xiaomi Redmi 9", Price = 2000 },
            new Good() { Id = Guid.NewGuid(), Name = "HP laptop", Price = 12000 },
            new Good() { Id = Guid.NewGuid(), Name = "Nationaly Patterned Cup", Price = 400 },
        };
        protected ICollection<Good> Avaliable_goods
        {
            get
            {
                Thread.Sleep(2000); // retriving goods from base
                return _avaliable_goods;
            }
        }

        public Shop(string address)
        {
            Adresss = address;
        }
        public virtual void GreetCameClient(Client c)
        {
            Console.WriteLine($"Hi, {c.Username}. Welcome to {ShopType} shop!");
        }
        public virtual void ShowAdressInfo()
        {
            Console.WriteLine($"You've came by {Adresss} address");
        }
        public abstract void ShowGoods();
        public virtual void GetClientPurchase(Client c)
        {
            sellerContext.Message = "Make Choice";
            sellerContext.ShowSellersMessage();

            var goodsList = this.Avaliable_goods.ToList();

            var goodChosen = goodsList[AskForInteger("Choice") - 1];
            c.Cart.Add(goodChosen);
        }
        public virtual void GetMoneyForGoods(Client c)
        {
            decimal costSum = c.Cart.Sum(obj => obj.Price);

            sellerContext.Message = $"For All: {costSum:f2}. Equip? (1- yes, 0 - no)";
            sellerContext.ShowSellersMessage();

            int choice = AskForInteger("Choice");
            if (choice != 1 && choice != 0)
            {
                throw new InvalidOperationException("Wrong Variant!");
            }
            else if (choice == 0)
            {
                throw new InvalidOperationException("Jump to Payment is Canceled!");
            }

            DisplayPaymentWays();
            PaymentContext paymentContext = new();
            switch ((PaymentWays)AskForInteger("Choose Payment way"))
            {
                case PaymentWays.Card:
                    paymentContext.Payment = new CardPayment();
                    break;
                case PaymentWays.Cash:
                    paymentContext.Payment = new CashPayment();
                    break;
                default:
                    throw new InvalidOperationException("No such payment way!");
            }

            paymentContext.AmountOfDebit = costSum;
            paymentContext.Client = c;

            paymentContext.Debit();
            //DisplayClientBalance(c);
        }
        public virtual void DeliverGoods(ICollection<Good> goods)
        {
            DisplayDeliveryWays();

            DeliveryContext deliveryContext = new();
            deliveryContext.Goods = goods;

            switch ((DeliveryWay)AskForInteger("Delvery kind"))
            {
                case DeliveryWay.Courier:
                    deliveryContext.Delivery = new CourierDelivery();
                    break;
                case DeliveryWay.SelfPicking:
                    deliveryContext.Delivery = new SelfPickingDelivery();
                    break;
                default:
                    throw new InvalidOperationException("No such delivery way!");
            }

            Console.WriteLine("Proceeding delivery");
            deliveryContext.Deliver();
            goods.Clear();
        }

        protected void DisplayClientBalance(Client c)
        {
            sellerContext.Message = $"Balance is {c.Balance} UAH";
            sellerContext.ShowSellersMessage();
        }

        protected static void DisplayPaymentWays()
        {
            Console.WriteLine();
            Console.WriteLine($"{(int)PaymentWays.Card} - {PaymentWays.Card}");
            Console.WriteLine($"{(int)PaymentWays.Cash} - {PaymentWays.Cash}");
            Console.WriteLine();
        }
        protected static void DisplayDeliveryWays()
        {
            Console.WriteLine();
            Console.WriteLine($"{(int)DeliveryWay.Courier} - {DeliveryWay.Courier}");
            Console.WriteLine($"{(int)DeliveryWay.SelfPicking} - {DeliveryWay.SelfPicking}");
            Console.WriteLine();
        }
        protected static int AskForInteger(string message)
        {
            Console.Write($"\n{message}> ");
            return int.Parse(Console.ReadLine());
        }
    }
}
