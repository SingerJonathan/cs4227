namespace cs4227.Restaurant
{
    public class FoodItem
    {
        public FoodItem()
        {
            Name = "Food Item";
            Cost = 0.0f;
            Deleted = false;
            Discounts = new double[] {0, 0, 0, 0};
        }

        public FoodItem(int id, string name, double cost, int restaurantId, double bronzediscount,
            double silverdiscount, double golddiscount, bool deleted = false)
        {
            Id = id;
            Name = name;
            Cost = cost;
            RestaurantId = restaurantId;
            Deleted = deleted;
            Discounts = new[] {0, bronzediscount, silverdiscount, golddiscount};
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Cost { get; set; }

        public int RestaurantId { get; set; }

        public bool Deleted { get; set; }

        public double[] Discounts { get; set; }
    }
}