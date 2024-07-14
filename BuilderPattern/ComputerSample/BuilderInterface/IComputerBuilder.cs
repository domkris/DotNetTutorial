using BuilderPattern.ComputerSample.Product;

namespace BuilderPattern.ComputerSample.BuilderInterface
{
    public interface IComputerBuilder
    {
        Computer Build();
    }
}
