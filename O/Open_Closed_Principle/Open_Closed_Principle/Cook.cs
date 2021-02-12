using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Closed_Principle
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner()
        {
            Console.WriteLine("Clean potatoes");
            Console.WriteLine("Boild potatoes");
            Console.WriteLine("Drain water, de-boil boiled potatoes in mashed potatoes");
            Console.WriteLine("Mashed with spices and greens");
            Console.WriteLine("Mashed Potatoes Ready");
        }
    }
}
