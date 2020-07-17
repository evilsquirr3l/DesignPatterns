using System;

namespace DesignPatterns.Structural_Patterns.Proxy
{
    public class ProxyEbook : IEbook
    {
        private string _fileName;
        private EBook _eBook;

        public ProxyEbook(string fileName)
        {
            _fileName = fileName;
        }

        public void Load()
        {
            _eBook ??= new EBook(_fileName + " proxy");

            _eBook.Load();
        }

        public void Show()
        {
            _eBook ??= new EBook(_fileName + " proxy");
            
            _eBook.Show();
        }

        public string GetFileName()
        {
            return _fileName;
        }
    }
}