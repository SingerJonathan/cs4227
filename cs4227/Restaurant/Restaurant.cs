namespace cs4227.Restaurant
{
    public class Restaurant
    {
        public Restaurant()
        {
            Name = "None";
            Delivery = 0;
            Deleted = false;
        }

        public Restaurant(int id, string name, string address, int ownerId, string phone, string email,
            string openingHours, string closingHours, string days, string type, double delivery, bool deleted)
        {
            Id = id;
            Name = name;
            Address = address;
            OwnerId = ownerId;
            Phone = phone;
            Email = email;
            OpeningHours = openingHours;
            ClosingHours = closingHours;
            Days = days;
            Type = type;
            Delivery = delivery;
            Deleted = deleted;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int OwnerId { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string OpeningHours { get; set; }

        public string ClosingHours { get; set; }

        public string Days { get; set; }

        public string Type { get; set; }

        public double Delivery { get; set; }

        public bool Deleted { get; set; }
    }
}