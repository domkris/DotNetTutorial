namespace BuilderPattern.ComputerSample.Product
{
    public class Computer
    {
        public string Name { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string Storage { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Processor: {Processor}, Memory: {Memory}, Storage: {Storage}";
        }
    }
}
