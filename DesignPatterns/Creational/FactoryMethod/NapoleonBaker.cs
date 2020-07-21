namespace DesignPatterns.Creational.FactoryMethod
{
    public class NapoleonBaker : Baker
    {
        public override Cake CreateCake()
        {
            return new Napoleon();
        }
    }
}