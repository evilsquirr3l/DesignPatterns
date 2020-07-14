namespace DesignPatterns.Visitor
{
    public class HeadingNode : IElement
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}