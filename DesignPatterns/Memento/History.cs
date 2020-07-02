using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class History
    {
        public Stack<EditorState> States = new Stack<EditorState>();
    }
}