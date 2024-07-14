namespace SingletonPattern
{
    public sealed class SingletonDemo
    {
        private static SingletonDemo _instance;
        public static SingletonDemo Current => _instance ??= new SingletonDemo();

        public string Message { get; set; }
        public void Print()
        {
            Console.WriteLine(Message);
        }
    }
}
