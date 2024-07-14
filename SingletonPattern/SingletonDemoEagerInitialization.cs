namespace SingletonPattern
{
    public class SingletonDemoEagerInitialization
    {
        private static readonly SingletonDemoEagerInitialization instance = new SingletonDemoEagerInitialization();

        private SingletonDemoEagerInitialization() { }

        public static SingletonDemoEagerInitialization Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
