using System;

namespace DesignPatterns.Structural_Patterns.Bridge
{
    public class SonyTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on sony");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off sony");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Set sonyTV channel to {channel}");
        }
    }
}