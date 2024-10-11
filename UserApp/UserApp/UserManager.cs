using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal static class UserManager
    {
        public static List<User> users { get; set; } = new List<User>();

        public static void MethodCall()
        {
            while(true)
            {
                Console.WriteLine("Choose an option:\n1. Register\n2. Login\n3. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Authenticate();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Ivalid choice.");
                        break;
                }
            }
        }

        private static void Register()
        {
            string username = getValidUsername();
            Console.Write("Enter fullname: ");
            string fullName = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Email: ");
            string Email = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string PhoneNumber = Console.ReadLine();
            Console.Write("Enter address: ");
            string Address = Console.ReadLine();
            Console.Write("Enter age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Select a role:\n 0. User,\n 1. Admin");
            Role role = getValidRole();
            User user = new User(fullName, password, username, Email, PhoneNumber, Address, Age, role);
            users.Add(user);
        }

        private static void Authenticate()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            foreach(User user in users)
            {
                if(user.Username == username && user.Password == password)
                {
                    getUserInfo(user);
                    return;
                }
            }
            Console.WriteLine("No such user found :/ ");
        }

        private static void getUserInfo(User user)
        {
            Console.WriteLine("User info: ");
            Console.WriteLine($"Username: {user.Username},\nFullName: {user.FullName},\nAddress: {user.Address},\nPhone Number: {user.PhoneNumber},\nRole: {user.UserRole.ToString()} ");

            if (user.UserRole == Role.Admin)
            {
                Console.WriteLine("All the users:\n ");
                foreach(User user2 in users)
                {
                    if(user.Username != user2.Username)
                    {
                        Console.WriteLine(user2.ToString() +"\n");
                        Console.WriteLine();
                    }
                }
            }
        }

        private static string getValidUsername()
        {
            string username;
            bool usernameExists;
            do
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine();
                usernameExists = false;
                foreach (User user2 in users)
                {
                    if (user2.Username == username)
                    {
                        Console.WriteLine("Username already exists");
                        usernameExists = true;
                        break;
                    }
                }
            } while (usernameExists);
            return username;
        }

        private static Role getValidRole()
        {
            Role role = 0;
            while(true)
            {
                Console.WriteLine("Please enter 0 for User or 1 for Admin:");
                int roleNumber = int.Parse(Console.ReadLine());
                if (roleNumber == 0)
                {
                    role = Role.User;
                    break;
                }
                else if (roleNumber == 1)
                {
                    role = Role.Admin;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 0 for User or 1 for Admin.");
                }
            }       
            return role;
        }
    }
}
