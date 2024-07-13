using FactoryMethodPattern.ProductInterface;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class PdfDocument : IDocument
    {
        public void Close()
        {
            Console.WriteLine("Closing PDF Document");
        }

        public void Open()
        {
            Console.WriteLine("Opening PDF Document");
        }

        public void Save()
        {
            Console.WriteLine("Saving PDF Document");
        }
    }
}
