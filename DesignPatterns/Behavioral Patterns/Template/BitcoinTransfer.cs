using System;

namespace DesignPatterns.Behavioral_Patterns.Template
{
    public class BitcoinTransfer : MoneyTransfer
    {
        protected override void Log()
        {
            Console.WriteLine("Bitcoin logger");
        }

        protected override void Transfer()
        {
            Console.WriteLine("Transfer bitcoin");
        }
    }
}