namespace DesignPatterns.Creational.Builder
{
    public interface AbstractBuilder
    {
        public abstract void BuildRoof();

        public abstract void BuildBasement();

        public abstract void BuildStorey();

        public House GetResult();
    }
}