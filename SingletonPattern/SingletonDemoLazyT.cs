namespace SingletonPattern
{
    public class SingletonDemoLazyT
    {
        private static readonly Lazy<SingletonDemoLazyT> lazy =
        new(() => new SingletonDemoLazyT());

        private SingletonDemoLazyT() { }

        public static SingletonDemoLazyT Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
