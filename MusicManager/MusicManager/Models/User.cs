using System;

namespace MusicManagerUI
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
            Email = email.ToLower();
            Password = password.ToLower();
        }

        /// <summary>
        /// Returns true if login attempt successful, false if unsuccessful
        /// CASE INSENSITIVE
        /// </summary>
        /// <param name="email">email attempt</param>
        /// <param name="password">password attempt</param>
        /// <returns>bool true, if successful, false if unsuccessful</returns>
        public bool LoginAttempt(string email, string password)
        {
            return ((email.ToLower().Equals(Email)) && (password.ToLower().Equals(Password)));
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
