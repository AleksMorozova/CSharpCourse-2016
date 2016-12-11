using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService
{
    public static class UserList
    {
        static List<User> users = new List<User>();

        static UserList()
        {
            Role adminRole = new Role() { Id = 0, Name = "Admin" };
            Role customerRole = new Role() { Id = 1, Name = "Customer" };

            User admin = new User()
            {
                Id = 0,
                Login = "admin",
                Password = "123"
            };

            User customer = new User()
            {
                Id = 0,
                Login = "customer",
                Password = "123"
            };

            admin.Roles.Add(adminRole);
            customer.Roles.Add(customerRole);

            users.Add(admin);
            users.Add(customer);
        }

        public static List<User> GetUsers
        {
            get { return users; }
        }
    }
}