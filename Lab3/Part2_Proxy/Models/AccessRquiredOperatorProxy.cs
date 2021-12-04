using System;

namespace Part2_Proxy.Models
{
    public class AccessRquiredOperatorProxy : Operator
    {
        private readonly FullAccessOperator _operator;

        public AccessRquiredOperatorProxy(FullAccessOperator oper)
        {
            _operator = oper;
        }
       
        public override bool ChangeClientsTariff(Client client)
        {
            if (GetPUK() == client.PUK_code)
            {
                return _operator.ChangeClientsTariff(client);
            }
            else
            {
                Console.WriteLine("Invalid PUK!");
            }

            return false;
        }

        protected override void DisplayTariffs()
        {
            throw new InvalidOperationException();
        }

        private string GetPUK()
        {
            Console.Write($"Enter PUK:\n>");
            return Console.ReadLine();
        }
    }
}
