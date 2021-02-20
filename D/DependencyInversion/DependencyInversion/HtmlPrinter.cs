using System;

namespace DependencyInversion
{
    class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Pring in html");
        }
    }
}
