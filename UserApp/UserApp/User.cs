using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public enum Role
    {
        User = 1, 
        Admin 
    }
    internal class User
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber{ get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Role UserRole { get; set; }

        public User(string fullName, string password, string username, string email, string phoneNumber, string address, int age, Role userRole)
        {
            FullName = fullName;
            Password = password;
            Username = username;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Age = age;
            UserRole = userRole;
        }

        public override string? ToString()
        {
          return $"Full Name: {FullName}\n" +
          $"Username: {Username}\n" +
          $"Email: {Email}\n" +
          $"Phone Number: {PhoneNumber}\n" +
          $"Address: {Address}\n" +
          $"Age: {Age}\n" +
          $"Role: {UserRole}";
        }
    }
}
