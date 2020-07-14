namespace DesignPatterns.Behavioral_Patterns.Command.Undo
{
    public class BoldCommand : IUndoableCommand
    {
        private string _prevContent;
        private History _history;
        private Document _document;

        public BoldCommand(History history, Document document)
        {
            _history = history;
            _document = document;
        }

        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeBold();
            _history.Enqueue(this);
        }

        public void Unexecute()  
        {
            _document.Content = _prevContent;
        }
    }
}