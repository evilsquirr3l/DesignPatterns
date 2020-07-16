using System;
using DesignPatterns.Behavioral_Patterns.Visitor;
using DesignPatterns.Structural_Patterns.Adapter;
using DesignPatterns.Structural_Patterns.Composite;
using DesignPatterns.Structural_Patterns.Decorator;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveCreditCard(new CompressedCloudStorage(new EncryptedCloudStorage(new CloudStorage())));
            
            
        }

        static void SaveCreditCard(IStream stream)
        {
            stream.Write("some data");
        }
    }
}