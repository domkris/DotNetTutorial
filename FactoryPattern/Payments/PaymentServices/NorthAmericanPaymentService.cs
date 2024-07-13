using FactoryPattern.Payments.Enums;

namespace FactoryPattern.Payments.PaymentServices
{
    public class NorthAmericanPaymentService : IPaymentService
    {
        public string? EmailToCharge { get; set; }
        public decimal MoneyToCharge { get; set; }
        public ChargingOptions OptionToCharge { get; set; }

        public bool ProcessCharging()
        {
            Console.WriteLine("");
            Console.WriteLine("This payment will be processed by NorthAmerican Payment Service.");
            Console.WriteLine($"Person: {EmailToCharge}");
            Console.WriteLine($"Price: {MoneyToCharge:0.00} USD");
            Console.WriteLine($"Option: {OptionToCharge}");
            Console.WriteLine("");
            return true;
        }
    }
}
