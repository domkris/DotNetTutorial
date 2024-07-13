using FactoryPattern.Payments.Enums;

namespace FactoryPattern.Payments.PaymentServices
{
    internal class SouthEuropeanPaymentService : IPaymentService
    {
        public string? EmailToCharge { get; set; }
        public decimal MoneyToCharge { get; set; }
        public ChargingOptions OptionToCharge { get; set; }

        public bool ProcessCharging()
        {
            Console.WriteLine("This payment will be processed by SouthEuropean Payment Service.");
            Console.WriteLine($"Person: {EmailToCharge}");
            Console.WriteLine($"Price: {MoneyToCharge:0.00} EUR");
            Console.WriteLine($"Option: {OptionToCharge}");
            Console.WriteLine("");
            return true;
        }
    }
}
