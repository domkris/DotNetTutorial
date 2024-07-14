using FactoryMethodPattern.ConcreteCreator;
using FactoryMethodPattern.ProductInterface;
using FactoryPattern.Payments;
using FactoryPattern.Vehicles;
using SingletonPattern;

namespace ConsoleMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FactoryPatternSample

            //Vehicles
            FactoryPatternSample_Vehicles1();

            //Payments
            FactoryPatternSample_Payments1();
            #endregion

            #region FactoryMethodPatternSample

            //Documents
            FactoryMethodPatternSample_Documents1();

            #endregion

            #region SingletonSample
            SingletonDemo.Current.Message = "This is singleton";
            SingletonDemo.Current.Print();
            #endregion

        }

        private static void FactoryMethodPatternSample_Documents1()
        {
            DocumentFactory factory = new();

            IDocument wordDocument = factory.Create(DocumentType.Word);
            wordDocument.Open();
            wordDocument.Save();
            wordDocument.Close();

            IDocument pdfDocument = factory.Create(DocumentType.PDF);
            pdfDocument.Open();
            pdfDocument.Save();
            pdfDocument.Close();
        }

        private static void FactoryPatternSample_Payments1()
        {
            IPaymentService southEuropeanPaymentService = PaymentServiceFactory.Create(Services.SouthEuropean);
            southEuropeanPaymentService.OptionToCharge = FactoryPattern.Payments.Enums.ChargingOptions.CreditCard;
            southEuropeanPaymentService.EmailToCharge = "test@southEuropean.test";
            southEuropeanPaymentService.MoneyToCharge = 50;
            southEuropeanPaymentService.ProcessCharging();

            IPaymentService northAmericanPaymentService = PaymentServiceFactory.Create(Services.NorthAmerican);
            northAmericanPaymentService.OptionToCharge = FactoryPattern.Payments.Enums.ChargingOptions.DebitCard;
            northAmericanPaymentService.EmailToCharge = "test@northAmerican.test";
            northAmericanPaymentService.MoneyToCharge = 70.5M;
            northAmericanPaymentService.ProcessCharging();

        }

        private static void FactoryPatternSample_Vehicles1()
        {
            IVehicle car = VehicleFactory.GetVehicle(VehicleType.Car);
            car.Drive();

            IVehicle bike = VehicleFactory.GetVehicle(VehicleType.Bike);
            bike.Drive();
        }
    }
}
