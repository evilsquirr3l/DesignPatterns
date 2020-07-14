namespace DesignPatterns.Behavioral_Patterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler Successor { get; set; }
        
        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract void Handle(int request);
    }
}