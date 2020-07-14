using System.Collections;

namespace DesignPatterns.Behavioral_Patterns.Iterator
{
    public class HistoryIteratorInReverseOrder : IEnumerator
    {
        private string[] _history;
        private int _index;

        public HistoryIteratorInReverseOrder(string[] history)
        {
            _history = history;
            _index = history.Length;
        }

        public bool MoveNext()
        {
            return --_index != -1;
        }

        public void Reset()
        {
            _index = _history.Length;
        }

        public object? Current => _history[_index];
    }
}