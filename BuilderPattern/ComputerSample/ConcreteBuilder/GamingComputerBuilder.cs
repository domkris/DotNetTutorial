using BuilderPattern.ComputerSample.BuilderInterface;
using BuilderPattern.ComputerSample.Product;

namespace BuilderPattern.ComputerSample.ConcreteBuilder
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer = new();
        public Computer Build()
        {
            _computer.Processor = "Intel Core i9";
            _computer.Memory = "32GB";
            _computer.Storage = "1TB SSD";
            _computer.Name = "Gaming Computer";
            return _computer;
        }
    }
}
