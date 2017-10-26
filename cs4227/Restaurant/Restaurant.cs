using System;

namespace cs4227.Restaurant
{
    class Restaurant
    {
        private int id;
        private string name;
        private int ownerId;
        private string phone;
        private string email;
        private string openingHours;
        private string closingHours;
        private string days;
        private string type;
        private double delivery;
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
        public int WwnerId
        {
            get { return ownerId; }
            set { ownerId = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string OpeningHours
        {
            get { return openingHours; }
            set { openingHours = value; }
        }
        public string ClosingHours
        {
            get { return closingHours; }
            set { closingHours = value; }
        }
        public string Days
        {
            get { return days; }
            set { days = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public Restaurant()
        {
            name = "Restaurant";
            delivery = 0;
            deleted = false;
        }

        public Restaurant(int id, string name, int ownerId, string phone, string email, string openingHours, string closingHours, string days, string type, double delivery, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.ownerId = ownerId;
            this.phone = phone;
            this.email = email;
            this.openingHours = openingHours;
            this.closingHours = closingHours;
            this.days = days;
            this.type = type;
            this.delivery = delivery;
            this.deleted = deleted;
        }
    }
}
