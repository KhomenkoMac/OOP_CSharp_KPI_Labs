using System;

namespace Part2_Proxy.Models
{
    public abstract class Operator
    {
        protected virtual void DisplayTariffs()
        {
            throw new InvalidOperationException();
        }
        protected virtual int GetTariffId()
        {
            Console.Write("Enter tariff id> ");
            return int.Parse(Console.ReadLine());
        }
        public abstract bool ChangeClientsTariff(Client client);
    }
}
