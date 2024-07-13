using FactoryPattern.Payments.PaymentServices;

namespace FactoryPattern.Payments
{
    public enum Services
    {
        SouthEuropean,
        NorthAmerican
    }

    public static class PaymentServiceFactory
    {
        
        public static IPaymentService Create(Services service)
        {
            return service switch
            {
                Services.SouthEuropean => new SouthEuropeanPaymentService(),
                Services.NorthAmerican => new NorthAmericanPaymentService(),
                _ => throw new ArgumentException("Invalid type"),
            };
        }
    }
}
