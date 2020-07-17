using System;
using DesignPatterns.Behavioral_Patterns.Visitor;
using DesignPatterns.Structural_Patterns.Adapter;
using DesignPatterns.Structural_Patterns.Bridge;
using DesignPatterns.Structural_Patterns.Composite;
using DesignPatterns.Structural_Patterns.Decorator;
using DesignPatterns.Structural_Patterns.Flyweight;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl(new SonyTv());
            
            remoteControl.TurnOn();
            remoteControl.TurnOff();
        }
    }
}