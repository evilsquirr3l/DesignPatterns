using System;

namespace DesignPatterns.Template
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