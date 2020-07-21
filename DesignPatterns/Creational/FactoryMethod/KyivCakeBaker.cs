namespace DesignPatterns.Creational.FactoryMethod
{
    public class KyivCakeBaker : Baker
    {
        public override Cake CreateCake()
        {
            return new KyivCake();
        }
    }
}