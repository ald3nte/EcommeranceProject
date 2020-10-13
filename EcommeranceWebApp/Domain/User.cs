using System;
using System.Collections.Generic;
using System.Text;

namespace EcommeranceWebApp.Domain
{
    public class User : Entity
    {
        private static List<string> _roles = new List<string>
        {
            "user", "admin"
        };
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Role { get; protected set; }

        protected User()
        {

        }

        public User(Guid id,string role,string firstName, string lastName,string email,string password)
        {
            Id = id;
            SetRole(role);
            FirstName = firstName;
            LastName = lastName;
            SetEmail(email);
            Password = password;
            CreatedAt = DateTime.UtcNow;
        }

        private void SetEmail(string email)
        {
            if(string.IsNullOrEmpty(email))
            {
                throw new Exception($"User can not have an empty email");
            }
            Email = email; 
        }


        private void SetRole(string role)
        {
            if (string.IsNullOrEmpty(role))
            {
                throw new Exception($"User can not have an empty role");
            }
            Role = role.ToLowerInvariant();
            if(!_roles.Contains(role))
            {
                throw new Exception($"User can not have a role: {role}");
            }
        }
    }
}
