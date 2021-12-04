namespace Part2_Proxy.Models
{
    public class TariffPlan
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}; Price: {Price}";
        }
    }
}
