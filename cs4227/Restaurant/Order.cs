using System.Collections.Generic;
using cs4227.Meal;
using cs4227.UI;

namespace cs4227.Restaurant
{
    public class Order
    {
        private double cost;

        public Order()
        {
            Cancelled = false;
            FoodItems = new List<FoodItem>();
        }

        public Order(int id, int userId, int restaurantId, List<FoodItem> foodItems, string address, double cost,
            bool cancelled = false)
        {
            Id = id;
            UserId = userId;
            RestaurantId = restaurantId;
            Cancelled = cancelled;
            FoodItems = new List<FoodItem>(foodItems);
            Address = address;
            this.cost = cost;
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public int RestaurantId { get; set; }

        public double Cost
        {
            //get { return cost; }
            get
            {
                var cost = 0.00;
                var membership = StaticAccessor.DB.GetUser(UserId).Membership;
                foreach (var item in FoodItems)
                    cost += item.Cost - item.Discounts[membership];
                cost += StaticAccessor.DB.GetRestaurant(RestaurantId).Delivery;
                return cost;
            }
            set => cost = value;
        }

        public string Address { get; set; }

        public bool Cancelled { get; set; }

        public List<FoodItem> FoodItems { get; private set; }

        public void Add(FoodItem foodItem)
        {
            FoodItems.Add(foodItem);
        }

        public void Remove(FoodItem foodItem)
        {
            FoodItems.Remove(foodItem);
        }

        public Memento CreateMemento()
        {
            return new Memento(Id, UserId, Cancelled, FoodItems);
        }

        public void SetMemento(Memento memento)
        {
            Id = memento.id;
            UserId = memento.userId;
            Cancelled = memento.cancelled;
            FoodItems = new List<FoodItem>(memento.foodItems);
        }
    }
}