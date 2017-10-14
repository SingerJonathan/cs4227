using System;

namespace cs4227.Restaurant
{
    class FoodItem
    {
        private int id;
        private string name;
        private double cost;
        private int restaurantId;
        private bool deleted;

        public FoodItem()
        {
            name = "Food Item";
            cost = 0.0f;
        }

        public FoodItem(int id, string name, double cost, int restaurantId, bool deleted = false)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.restaurantId = restaurantId;
            this.deleted = deleted;
        }

        public string getName()
        {
            return name;
        }

        public double getCost()
        {
            return cost;
        }

        public int getId()
        {
            return id;
        }

        public int getRestaurantId()
        {
            return restaurantId;
        }

        public bool getDeleted()
        {
            return deleted;
        }
    }
}
