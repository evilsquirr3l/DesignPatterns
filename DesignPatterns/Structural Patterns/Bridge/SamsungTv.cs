using System;

namespace DesignPatterns.Structural_Patterns.Bridge
{
    public class SamsungTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on samsung");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off samsung");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Set samsung channel to {channel}");
        }
    }
}