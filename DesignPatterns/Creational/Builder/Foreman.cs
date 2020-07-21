namespace DesignPatterns.Creational.Builder
{
    public class Foreman
    {
        private AbstractBuilder _abstractBuilder;

        public Foreman(AbstractBuilder abstractBuilder)
        {
            _abstractBuilder = abstractBuilder;
        }

        public void Construct()
        {
            _abstractBuilder.BuildBasement();
            _abstractBuilder.BuildRoof();
            _abstractBuilder.BuildStorey();
        }
    }
}