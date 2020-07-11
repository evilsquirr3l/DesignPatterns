using System;
using DesignPatterns.Command;
using DesignPatterns.Iterator;
using DesignPatterns.Strategy;
using DesignPatterns.Template;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var customerCommand = new CustomerServiceCommand(customerService);
            
            var button = new Button(customerCommand);
            button.Click();
        }
    }
}