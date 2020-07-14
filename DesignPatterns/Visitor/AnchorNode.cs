namespace DesignPatterns.Visitor
{
    public class AnchorNode : IElement
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}