namespace DesignPatterns.Behavioral_Patterns.Template
{
    public abstract class MoneyTransfer
    {
        public void TransferMoney()
        {
            Log();
            
            Transfer();
        }

        protected abstract void Log();

        protected abstract void Transfer();
    }
}