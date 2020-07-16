namespace DesignPatterns.Structural_Patterns.Facade
{
    public class Notepad
    {
        private TextEditor _editor;
        private Saver _saver;
        private Drawer _drawer;

        public Notepad(TextEditor editor, Saver saver, Drawer drawer)
        {
            _editor = editor;
            _saver = saver;
            _drawer = drawer;
        }

        public void Draw()
        {
            _drawer.Draw();
            _saver.Save();
        }

        public void PrintText(string message)
        {
            _editor.PrintText(message);
            _saver.Save();
        }
    }
}