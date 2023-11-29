using System;

namespace MusicData.Models
{
    public class User
    {
        public int UserID { get; }
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        public User(int userId, string name, string email, string password)
        {
            UserID = userId;
            Name = name;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
