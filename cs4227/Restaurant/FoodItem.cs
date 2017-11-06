using System;

namespace cs4227.Restaurant
{
    public class FoodItem
    {
        private int id;
        private string name;
        private double cost;
        private int restaurantId;
        private bool deleted;
        private double bronzediscount;
        private double silverdiscount;
        private double golddiscount;


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
        public double BronzeDiscount
        {
            get { return bronzediscount; }
            set { bronzediscount = value; }
        }
        public double SilverDiscount
        {
            get { return silverdiscount; }
            set { silverdiscount = value; }
        }
        public double GoldDiscount
        {
            get { return golddiscount; }
            set { golddiscount = value; }
        }

        public FoodItem()
        {
            name = "Food Item";
            cost = 0.0f;
            deleted = false;
            bronzediscount = 0.0f;
            silverdiscount = 0.0f;
            golddiscount = 0.0f;
        }

        public FoodItem(int id, string name, double cost, int restaurantId, double bronzediscount, double silverdiscount, double golddiscount, bool deleted = false)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.restaurantId = restaurantId;
            this.deleted = deleted;
            this.bronzediscount = bronzediscount;
            this.silverdiscount = silverdiscount;
            this.golddiscount = golddiscount;
        }
    }
}
