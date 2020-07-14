namespace DesignPatterns.Behavioral_Patterns.Visitor
{
    public class HeadingNode : IElement
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}