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

        public Order()
        {
            cancelled = false;
            foodItems = new List<FoodItem>();
        }

        public Order(List<FoodItem> foodItems)
        {
            cancelled = false;
            this.foodItems = foodItems;
        }

        public void Add(FoodItem foodItem)
        {
            foodItems.Add(foodItem);
        }

        public void Remove(FoodItem foodItem)
        {
            foodItems.Remove(foodItem);
        }

        public void SetUserId(int userId)
        {
            this.userId = userId;
        }

        public int GetUserId()
        {
            return userId;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetCancelled(bool cancelled)
        {
            this.cancelled = cancelled;
        }

        public bool GetCancelled()
        {
            return cancelled;
        }

        public List<FoodItem> GetItems()
        {
            return foodItems;
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
