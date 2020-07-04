using System.Collections;

namespace DesignPatterns.Iterator
{
    public class HistoryOverTwoIterator : IEnumerator
    {
        private string[] _history;
        private int _index;

        public HistoryOverTwoIterator(string[] history)
        {
            _history = history;
            _index = -1;
        }

        public bool MoveNext()
        {
            _index += 2;
            
            if (_index >= _history.Length)
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