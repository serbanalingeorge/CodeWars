namespace SplitStrings
{
    public class Singleton
    {
        private Singleton()
        {
            //prevent outside instantiation
        }

        private static readonly Singleton instance = new Singleton();

        public static Singleton GetInstance()
        {
            return instance;
        }

    }
}