using System;

namespace DesignPatterns.Behavioral_Patterns.Template
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