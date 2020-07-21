namespace DesignPatterns.Creational.Prototype
{
    public abstract class Prototype
    {
        protected Prototype(int id)
        {
            Id = id;
        }

        public abstract Prototype Clone();

        public int Id { get; private set; }
    }
}