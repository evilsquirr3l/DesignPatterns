using System;

namespace DesignPatterns.Structural_Patterns.Decorator
{
    public class CompressedCloudStorage : IStream
    {
        private IStream _stream;

        public CompressedCloudStorage(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var newData = data + " compressed";
            
            _stream.Write(newData);
        }
    }
}