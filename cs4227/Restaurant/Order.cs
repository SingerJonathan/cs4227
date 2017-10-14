using System;
using System.Collections.Generic;

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

        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public int getUserId()
        {
            return userId;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setCancelled(bool cancelled)
        {
            this.cancelled = cancelled;
        }

        public bool getCancelled()
        {
            return cancelled;
        }

        public List<FoodItem> getItems()
        {
            return foodItems;
        }
    }
}
