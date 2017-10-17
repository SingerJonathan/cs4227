using System;
using System.Collections.Generic;

namespace cs4227.source.Users
{
    public class Admin
    {
        private String Username;
        private String Name;
        private String Password;
        private Boolean SysAdmin;
        private List<Admin> ListOfAdmins;

        public Admin(String Username, String Name, String Password, Boolean SysAdmin)
        {
            this.Username = Username;
            this.Name = Name;
            this.Password = Password;
            this.SysAdmin = SysAdmin;
            ListOfAdmins = new List<Admin>();
        }

        public void AddAdmin(Admin e)
        {
            ListOfAdmins.Add(e);
        }

        public void RemoveAdmin(Admin e)
        {
            ListOfAdmins.Remove(e);
        }

        public List<Admin> getListOfAdmins()
        {
            return ListOfAdmins;
        }

        public String toString()
        {
            return ("Admin: [Name: " + Name + " | Username: " + Username + " | SysAdmin: " + SysAdmin + "]");
        }
    }
}
