using System;

namespace Open_Closed_Principle
{
    class PotatoMeal : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Boild potatoes");
            Console.WriteLine("Drain water, de-boil boiled potatoes in mashed potatoes");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Mashed with spices and greens");
            Console.WriteLine("Mashed Potatoes Ready");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Clean potatoes");
        }
    }
}
