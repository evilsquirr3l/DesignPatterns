namespace DesignPatterns.Visitor
{
    public interface IElement
    {
        void Execute(IOperation operation);
    }
}