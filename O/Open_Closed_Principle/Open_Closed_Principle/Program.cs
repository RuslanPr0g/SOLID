using System;

namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBase[] menu = new MealBase[] { new PotatoMeal(), new SaladMeal() };

            Cook bob = new Cook("Bob");

            bob.MakeDinner(menu);
        }
    }
}
