using System;

namespace Open_Closed_Principle
{
    class SaladMeal : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Cut tomatoes and cucumbers");
            Console.WriteLine("Sprinkle with green, salt and spices");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Sprinkle with sunflower oil");
            Console.WriteLine("Salad ready");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Wash tomatoes and cucumbers");
        }
    }
}
