using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs4227.Restaurant;

namespace cs4227.Meal
{
    class Memento
    {
        private int id;
        private int userId;
        private bool cancelled;
        private List<FoodItem> foodItems;

        public Memento() { }

        public Memento(int _id, int _userId, bool _cancelled, List<FoodItem> _foodItems)
        {
            this.id = _id;
            this.userId = _userId;
            this.cancelled = _cancelled;
            this.foodItems = _foodItems;
            Console.Write("Memento added: Order ID: {0}, User ID: {1}, Cancelled: {2}, Items: ", id, userId, cancelled );
            for (int i = 0; i < this.foodItems.Count; i++)
                Console.Write("{0}, ", foodItems[i].getName());
            Console.WriteLine("\n");
        }


        /*public void setMementoState(int _id, int _userId, bool _cancelled, List<FoodItem> _foodItems)
        {
            this.id = _id;
            this.userId = _userId;
            this.cancelled = _cancelled;
            this.foodItems = _foodItems;
        }
         */
    }
}
