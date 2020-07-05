namespace DesignPatterns.Template
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