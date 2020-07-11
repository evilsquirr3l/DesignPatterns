using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class History
    {
        private Stack<EditorState> _editorStates { get; } = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            _editorStates.Push(state);
        }

        public EditorState Pop()
        {
            return _editorStates.Pop();
        }
    }
}