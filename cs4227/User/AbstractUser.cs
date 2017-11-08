﻿using System;

namespace cs4227.User
{
    public abstract class AbstractUser
    {
        protected LoginAPI loginAPI;
        protected int id;
        protected string username;
        protected string firstName;
        protected string lastName;
        protected string password;
        protected string email;
        protected int membership;
        protected int restaurantId;
        protected bool restaurantAdmin;
        protected bool systemAdmin;
        protected bool deleted;

        public AbstractUser()
        {
        }

        public AbstractUser(int id, string username, string password, string firstName, string lastName, string email, int membership,
             LoginAPI loginAPI, int restaurantId = 0, bool restaurantAdmin = false, bool systemAdmin = false, bool deleted = false)
        {
            this.id = id;
            this.loginAPI = loginAPI;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.membership = membership;
            this.restaurantId = restaurantId;
            this.restaurantAdmin = restaurantAdmin;
            this.systemAdmin = systemAdmin;
            this.deleted = deleted;
        }

        public abstract void login();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Membership
        {
            get { return membership; }
            set { membership = value; }
        }
        public LoginAPI LoginAPI
        {
            get { return loginAPI; }
            set { loginAPI = value; }
        }
        public int RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }
        public bool RestaurantAdmin
        {
            get { return restaurantAdmin; }
            set { restaurantAdmin = value; }
        }
        public bool SystemAdmin
        {
            get { return systemAdmin; }
            set { systemAdmin = value; }
        }
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
