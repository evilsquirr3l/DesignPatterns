namespace DesignPatterns.Behavioral_Patterns.Visitor
{
    public class AnchorNode : IElement
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}