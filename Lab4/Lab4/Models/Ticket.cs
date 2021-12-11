using System;
using System.Linq;
using System.Text;

namespace Lab4.Models
{
    public class Ticket
    {
        public string FilmName { get; set; }
        public decimal Price { get; set; }
        public TimeSpan FilmTiming { get; set; }
        public int Row { get; set; }
        public int Seat { get; set; }

        public Ticket DeepClone()
        {
            Ticket clone = (Ticket)this.MemberwiseClone();
            clone.FilmName = new String(this.FilmName.ToArray());
            return clone;
        }

        public Ticket Clone()
        {
            return (Ticket)this.MemberwiseClone();
        }

        public override string ToString()
        {
            string s = "";
            s += $" {FilmName, 15}";
            s += $" {Price, 10}$";
            s += $" {FilmTiming, 10}";
            if (Row != default)
            {
                s += $" Row:{Row, 10}";
            }

            if (Seat != default)
            {
                s += $" Seat: {Seat, 4}";
            }
            
            return s;
        }
    }
}
