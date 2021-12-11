namespace Part1
{
    public interface Payment
    {
        void Debit(decimal amountOfDebit, Client client);
    }
}