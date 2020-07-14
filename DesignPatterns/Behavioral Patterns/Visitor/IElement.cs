namespace DesignPatterns.Behavioral_Patterns.Visitor
{
    public interface IElement
    {
        void Execute(IOperation operation);
    }
}