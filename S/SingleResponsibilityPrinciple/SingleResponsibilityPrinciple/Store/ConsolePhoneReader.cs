using System;

namespace SingleResponsibilityPrinciple
{
    class ConsolePhoneReader : IPhoneReader
    {
        public string[] GetInputData()
        {
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            Console.WriteLine("Price:");
            string price = Console.ReadLine();
            return new string[] { model, price };
        }
    }
}
