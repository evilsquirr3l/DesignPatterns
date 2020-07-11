namespace DesignPatterns.Command.Undo
{
    public class BoldCommand : IUndoableCommand
    {
        private string prevContent;
        private History _history;
        private Document _document;

        public BoldCommand(History history, Document document)
        {
            _history = history;
            _document = document;
        }

        public void Execute()
        {
            prevContent = _document.Content;
            _document.MakeBold();
            _history.Enqueue(this);
        }

        public void Unexecute()  
        {
            _document.Content = prevContent;
        }
    }
}