using System;
using System.Collections.Generic;

namespace Part2_Proxy.Models
{
    public class FullAccessOperator: Operator
    {
        private IDictionary<int, TariffPlan> _operatorTariffPlans => new Dictionary<int, TariffPlan>
        {
            { 1, new TariffPlan(){ Name = "Super NET Start", Price = 200 } },
            { 2, new TariffPlan(){ Name = "Super NET Advanced", Price = 300 } },
            { 3, new TariffPlan(){ Name = "MLS ss 123", Price = 50 } },
            { 4, new TariffPlan(){ Name = "5G Net Super", Price = 280 } }
        };

        protected override void DisplayTariffs() // чи краще зробити метод з нелогічним передаванням
        {
            Console.WriteLine("Avaliable tariffs");
            foreach (var item in _operatorTariffPlans)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();
        }

        public override bool ChangeClientsTariff(Client client)
        {
            DisplayTariffs();

            var tariffToChangeOn = _operatorTariffPlans[GetTariffId()];

            decimal balanceAfterPurchase = client.Balance - tariffToChangeOn.Price;
            bool isEnoughMoney = balanceAfterPurchase >= 0;
            
            if (isEnoughMoney)
            {
                client.CurrentTariffPlan = tariffToChangeOn;
                client.Balance = balanceAfterPurchase;
                Console.WriteLine($"Succeed! Current tariff is {client.CurrentTariffPlan}");
            }
            else
            {
                Console.WriteLine("There is not enough money for this tariff!");
            }

            return isEnoughMoney;
        }
    }
}
