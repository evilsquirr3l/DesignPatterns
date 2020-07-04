using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Iterator
{
    public class History : IEnumerable
    {
        private List<string> _history = new List<string>();

        public History(params string[] items)
        {
            _history.AddRange(items);
        }

        public IEnumerator GetEnumerator()
        {
            return new HistoryIterator(_history.ToArray());
        }

        public IEnumerator IterateOverTwo()
        {
            return new HistoryOverTwoIterator(_history.ToArray());
        }

        public IEnumerator IterateInReverseOrder()
        {
            return new HistoryIteratorInReverseOrder(_history.ToArray());
        }
    }
}