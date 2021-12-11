using System.Collections.Generic;

namespace Part1
{
    public class Client
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public decimal Balance { get; set; }
        public ICollection<Good> Cart { get; } = new List<Good>();
    }
}
