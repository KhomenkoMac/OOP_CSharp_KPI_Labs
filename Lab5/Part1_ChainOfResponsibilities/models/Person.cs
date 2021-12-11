using System;

namespace Part2_ChainOfResponsibilities
{
    public interface IHandler
    {
        IHandler SetNextNexus(IHandler handler);
        bool ProcessBargain(Ticket initOwner_Ticket);
    }
    public abstract class BaseHandler: IHandler
    {
        private IHandler _approver;

        public virtual bool ProcessBargain(Ticket initOwner_Ticket)
        {
            if (_approver == null)
            {
                return false;
            }
            else
            {
                return _approver.ProcessBargain(initOwner_Ticket);
            }
        }

        public IHandler SetNextNexus(IHandler approver)
        {
            _approver = approver;
            return _approver;
        }
    }

    public class Ticket
    {
        public string ShowName { get; set; }
        public decimal Price { get; set; }
        public Person Owner { get; set; }
    }

    public class Person: BaseHandler
    {
        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        private bool _haveDesireForShow;
        public bool HaveDesireForShow
        {
            get { return _haveDesireForShow; }
            set { _haveDesireForShow = value; }
        }

        private Ticket _ticket;
        public Ticket Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }

        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


        public override bool ProcessBargain(Ticket ticket)
        {
            if (_ticket is null && HaveDesireForShow)
            {
                _balance -= ticket.Price;
                ticket.Owner.Balance += ticket.Price;
                
                _ticket = ticket;
                ticket.Owner.Ticket = null;

                ticket.Owner = this;

                return true;
            }
            else
            {
                return base.ProcessBargain(ticket);
            }
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
