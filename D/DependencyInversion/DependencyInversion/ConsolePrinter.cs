using System;

namespace DependencyInversion
{
    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Print in console");
        }
    }
}
