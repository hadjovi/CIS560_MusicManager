using System;
using MusicData.Models;

namespace MusicManagerUI
{
    public class UiUser : User
    {
        public UiUser(int userId, string name, string email, string password) : base(userId, name, email, password)
        {
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
