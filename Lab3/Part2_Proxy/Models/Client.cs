using System;

namespace Part2_Proxy.Models
{
    public class Client
    {
        public Guid Id { get; } = Guid.NewGuid();
        public TariffPlan CurrentTariffPlan { get; set; }
        public decimal Balance { get; set; }
        public string PhoneNumber { get; set; }
        public string PUK_code { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}; {nameof(Balance)}: {Balance};\n{nameof(CurrentTariffPlan)}: {CurrentTariffPlan};";
        }
    }
}