using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class History
    {
        public Stack<EditorState> EditorStates { get; private set; } = new Stack<EditorState>();
    }
}