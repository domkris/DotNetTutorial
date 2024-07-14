using BuilderPattern.ComputerSample.BuilderInterface;
using BuilderPattern.ComputerSample.Product;

namespace BuilderPattern.ComputerSample.ConcreteBuilder
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer = new();
        public Computer Build()
        {
            _computer.Processor = "Intel Core i5";
            _computer.Memory = "16GB";
            _computer.Storage = "512GB SSD";
            _computer.Name = "Office Computer";
            return _computer;
        }
    }
}
