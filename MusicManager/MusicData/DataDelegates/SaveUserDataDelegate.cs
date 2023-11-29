using MusicData.Models;
using DataAccess;

namespace MusicData.DataDelegates
{
    public class SaveUserDataDelegate : DataDelegate
    {
        private readonly int userId;
        private readonly string name;
        private readonly string email;
        private readonly string password;
        public SaveUserDataDelegate(int userId, string name, string email, string password) : base("User.SaveUser")
        {
            this.userId = userId;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", userId);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("Password", password);
        }
    }
}
