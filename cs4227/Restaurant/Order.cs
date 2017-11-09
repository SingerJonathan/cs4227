using System;
using System.Collections.Generic;
using cs4227.Database;
using cs4227.Meal;
using cs4227.UI;

namespace cs4227.Restaurant
{
    public class Order
    {
        private int id;
        private int userId;
        private int restaurantId;
        private double cost;
        private string address;
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
        public int RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }
        public double Cost
        {
            //get { return cost; }
            get
            {
                double cost = 0.00;
                int membership = StaticAccessor.DB.GetUser(userId).Membership;
                foreach (FoodItem item in foodItems)
                    cost += item.Cost - item.Discounts[membership];
                cost += StaticAccessor.DB.GetRestaurant(restaurantId).Delivery;
                return cost;
            }
            set { cost = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
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

        public Order(int id, int userId, int restaurantId, List<FoodItem> foodItems, string address, double cost, bool cancelled = false)
        {
            this.id = id;
            this.userId = userId;
            this.restaurantId = restaurantId;
            this.cancelled = cancelled;
            this.foodItems = new List<FoodItem>(foodItems);
            this.address = address;
            this.cost = cost;
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
