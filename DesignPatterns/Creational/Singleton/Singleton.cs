namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton _singleton;
        
        protected Singleton()
        {
            
        }

        public Singleton Instance()
        {
            return _singleton ??= new Singleton();
        }
    }
}