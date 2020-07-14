using System.Collections;

namespace DesignPatterns.Behavioral_Patterns.Iterator
{
    public class HistoryIterator : IEnumerator
    {
        private string[] _history;
        private int _index;

        public HistoryIterator(string[] history)
        {
            _history = history;
            _index = -1;
        }

        public bool MoveNext()
        {
            if (++_index == _history.Length)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            _index = -1;
        }

        public object? Current => _history[_index];
    }
}