using System;

namespace Open_Closed_Principle
{
    class SaladMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Cut tomatoes and cucumbers"); 
            Console.WriteLine("Sprinkle with green, salt and spices");
            Console.WriteLine("Sprinkle with sunflower oil");
            Console.WriteLine("Salad ready");
        }
    }
}
