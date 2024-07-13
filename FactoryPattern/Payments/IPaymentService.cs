using FactoryPattern.Payments.Enums;

namespace FactoryPattern.Payments
{
    public interface IPaymentService
    {
        string EmailToCharge { get; set; }
        decimal MoneyToCharge { get; set; }
        ChargingOptions OptionToCharge { get; set; }
        bool ProcessCharging();
    }
}
