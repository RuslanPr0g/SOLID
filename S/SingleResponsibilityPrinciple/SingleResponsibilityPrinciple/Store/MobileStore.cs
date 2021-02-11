using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class MobileStore
    {
        List<Phone> phones = new List<Phone>();
        public void Process()
        {
            Console.WriteLine("Enter model:");
            string model = Console.ReadLine();
            Console.WriteLine("Enter price:");
            int price = 0;
            bool result = Int32.TryParse(Console.ReadLine(), out price);

            if (result == false || price <= 0 || String.IsNullOrEmpty(model))
            {
                throw new Exception("Wrong data.");
            }
            else
            {
                phones.Add(new Phone { Model = model, Price = price });
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter("store.txt", true))
                {
                    //writer.WriteLine(model);
                    //writer.WriteLine(price);
                }
                Console.WriteLine("Data was successfully proceed.");
            }
        }
    }
}
