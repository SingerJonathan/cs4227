using System;
using System.Collections.Generic;
using cs4227.Meal;

namespace cs4227.Restaurant
{
    class Order
    {
        private int id;
        private int userId;
        private bool cancelled;
        private List<FoodItem> foodItems;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public bool Cancelled
        {
            get { return cancelled; }
            set { cancelled = value; }
        }
        public List<FoodItem> FoodItems
        {
            get { return foodItems; }
        }

        public Order()
        {
            cancelled = false;
            foodItems = new List<FoodItem>();
        }

        public Order(List<FoodItem> foodItems)
        {
            cancelled = false;
            this.foodItems = new List<FoodItem>(foodItems);
        }

        public void Add(FoodItem foodItem)
        {
            foodItems.Add(foodItem);
        }

        public void Remove(FoodItem foodItem)
        {
            foodItems.Remove(foodItem);
        }

        public Memento CreateMemento()
        {
            return new Memento(id, userId, cancelled, foodItems);
        }

        public void SetMemento(Memento memento)
        {
            id = memento.id;
            userId = memento.userId;
            cancelled = memento.cancelled;
            foodItems = new List<FoodItem>(memento.foodItems);
        }
    }
}
