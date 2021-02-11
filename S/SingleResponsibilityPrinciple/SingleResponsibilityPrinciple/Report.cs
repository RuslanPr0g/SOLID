using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class Report
    {
        public string Text { get; set; }
        public void GoToFirstPage()
        {
            Console.WriteLine("GoToFirstPage");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("GoToLastPage");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("GoToPage {0}", pageNumber);
        }

        public void Print()
        {
            Console.WriteLine("Print report...");
            Console.WriteLine(Text);
        }
    }
}
