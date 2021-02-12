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

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }
}
