using System;

namespace Open_Closed_Principle
{
    class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Clean potatoes");
            Console.WriteLine("Boild potatoes");
            Console.WriteLine("Drain water, de-boil boiled potatoes in mashed potatoes");
            Console.WriteLine("Mashed with spices and greens");
            Console.WriteLine("Mashed Potatoes Ready");
        }
    }
}
