namespace DesignPatterns.State
{
    public class Canvas
    {
        public ITool Tool { get; set; }

        public void MouseUp()
        {
            Tool.MouseUp();
        }

        public void MouseDown()
        {
            Tool.MouseDown();
        }
    }
}