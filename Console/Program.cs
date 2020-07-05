using System;
using DesignPatterns.Iterator;
using DesignPatterns.Strategy;
using DesignPatterns.Template;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var visaTransfer = new VisaTransfer();
            var bitcoinTransfer = new BitcoinTransfer();
            
            visaTransfer.TransferMoney();
            bitcoinTransfer.TransferMoney();
        }
    }
}