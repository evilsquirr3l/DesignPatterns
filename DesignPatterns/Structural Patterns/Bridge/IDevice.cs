namespace DesignPatterns.Structural_Patterns.Bridge
{
    public interface IDevice
    {
        void TurnOn();
        
        void TurnOff();
        
        void SetChannel(int channel);
    }
}