namespace Part1
{
    public class PaymentContext
    {
        private Payment _payment;
        public Payment Payment
        {
            set { _payment = value; }
        }

        private decimal _amountOfDebit;
        public decimal AmountOfDebit
        {
            set { _amountOfDebit = value; }
        }

        private Client _client;

        public Client Client
        {
            set { _client = value; }
        }

        public void Debit()
        {
            _payment.Debit(_amountOfDebit, _client);
        }
    }
}
