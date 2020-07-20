namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        private AbstractBottle _abstractBottle;
        private AbstractWater _abstractWater;
        
        public Client(AbstractFactory abstractFactory)
        {
            _abstractBottle = abstractFactory.CreateBottle();
            _abstractWater = abstractFactory.CreateWater();
        }

        public void Action()
        {
            _abstractBottle.Interact(_abstractWater);
        }
    }
}