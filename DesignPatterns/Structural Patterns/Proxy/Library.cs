using System.Collections.Generic;

namespace DesignPatterns.Structural_Patterns.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> _books = new Dictionary<string, IEbook>();

        public void Add(IEbook book)
        {
            _books.Add(book.GetFileName(), book);
        }

        public void Show(string fileName)
        {
            _books[fileName].Show();
        }
    }
}