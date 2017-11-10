using System;
using System.Collections.Generic;
using cs4227.Restaurant;

namespace cs4227.Meal
{
    public class Memento
    {
        public readonly bool cancelled;
        public readonly List<FoodItem> foodItems;
        public readonly int id;
        public readonly int userId;

        public Memento(int id, int userId, bool cancelled, List<FoodItem> foodItems)
        {
            this.id = id;
            this.userId = userId;
            this.cancelled = cancelled;
            this.foodItems = new List<FoodItem>(foodItems);

            Console.Write(@"Memento added: ");
            for (var i = 0; i < foodItems.Count; i++)
                Console.Write(@"{0}, ", foodItems[i].Name);
            Console.WriteLine();
        }
    }
}