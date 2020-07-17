namespace DesignPatterns.Structural_Patterns.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            
        }

        public void SetChannel(int channel)
        {
            _device.SetChannel(channel);
        }
    }
}