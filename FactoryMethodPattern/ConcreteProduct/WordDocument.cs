using FactoryMethodPattern.ProductInterface;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class WordDocument : IDocument
    {
        public void Close()
        {
            Console.WriteLine("Closing Word Document");
        }

        public void Open()
        {
            Console.WriteLine("Opening Word Document");
        }

        public void Save()
        {
            Console.WriteLine("Saving Word Document");
        }
    }
}
