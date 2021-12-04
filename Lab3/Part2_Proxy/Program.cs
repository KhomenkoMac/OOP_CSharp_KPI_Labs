using Part2_Proxy.Models;
using System;

namespace Part2_Proxy
{
    class Program
    {
        private static Client InitCurrentClient()
        {
            return new Client()
            {
                PhoneNumber = "000-111-88-99",
                Balance = 100,
                CurrentTariffPlan = null,
                PUK_code = "123"
            };
        }
        static void Main(string[] args)
        {
            var currentClient = InitCurrentClient();

            Console.WriteLine(currentClient);

            Operator oper = new AccessRquiredOperatorProxy(new FullAccessOperator());

            oper.ChangeClientsTariff(currentClient);
            Console.WriteLine(currentClient);
        }
    }
}
