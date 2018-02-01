using System;
using System.Collections.Generic;

namespace Teht2
{
    /// <summary>
    /// It's a refrigerator!
    /// </summary>
    class Fridge
    {
        public List<Food> Contents { get; set; }

        public Fridge()
        {
            Contents = new List<Food>();
        }
        
        public void WriteContents()
        {
            Console.WriteLine("Fridge contains:");
            foreach (Food food in Contents)
            {
                Console.WriteLine(food);
            }
        }
    }
}
