using System;

namespace DesignPatterns.Template
{
    public class VisaTransfer : MoneyTransfer
    {
        protected override void Log()
        {
            Console.WriteLine("Some logger");
        }

        protected override void Transfer()
        {
            Console.WriteLine("Transfer cash");
        }
    }
}