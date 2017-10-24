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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public int RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

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
    }
}
