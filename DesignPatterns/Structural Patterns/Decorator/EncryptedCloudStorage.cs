using System;

namespace DesignPatterns.Structural_Patterns.Decorator
{
    public class EncryptedCloudStorage : IStream
    {
        private IStream _stream;

        public EncryptedCloudStorage(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var newData = data + " encrypted";
            
            _stream.Write(newData);
        }
    }
}