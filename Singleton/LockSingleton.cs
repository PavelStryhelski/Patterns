namespace Singleton
{
    public sealed class LockSingleton
    {
        private static volatile LockSingleton _instance;
        private static object _syncObject = new object();
        private LockSingleton()
        {
            
        }

        public static LockSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new LockSingleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
