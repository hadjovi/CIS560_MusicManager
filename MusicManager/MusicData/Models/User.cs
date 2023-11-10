using System;

namespace MusicData.Models
{
    public class User
    {
        public int UserId { get; }
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        public User(int userId, string name, string email, string password)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
