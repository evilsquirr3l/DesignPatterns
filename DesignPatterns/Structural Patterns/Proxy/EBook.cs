using System;

namespace DesignPatterns.Structural_Patterns.Proxy
{
    public class EBook : IEbook
    {
        private string _filename;

        public EBook(string filename)
        {
            _filename = filename;
            Load();
        }

        public void Load()
        {
            Console.WriteLine($"Loading book {_filename}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing book {_filename}");
        }

        public string GetFileName()
        {
            return _filename;
        }
    }
}