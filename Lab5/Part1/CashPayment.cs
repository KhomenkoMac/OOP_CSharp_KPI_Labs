using System;
using System.Threading;

namespace Part1
{
    public class CashPayment : Payment
    {
        public void Debit(decimal amountOfDebit, Client client)
        {
            Console.WriteLine("Searching for cash...");
            Thread.Sleep(2000);

            decimal afterDebiting = client.Balance - amountOfDebit;
            client.Balance = afterDebiting >= 0 
                ? afterDebiting
                : throw new InvalidOperationException("Insufficient funds on balance!");
        }
    }
}