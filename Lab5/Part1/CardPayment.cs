using System;
using System.Threading;

namespace Part1
{
    public class CardPayment : Payment
    {
        public void Debit(decimal amountOfDebit, Client client)
        {
            Console.WriteLine("Waiting for transaction...");
            Thread.Sleep(6000);

            decimal afterDebiting = client.Balance - amountOfDebit;
            client.Balance = afterDebiting >= 0
                ? afterDebiting
                : throw new InvalidOperationException("Insufficient funds on balance!");
        }
    }
}