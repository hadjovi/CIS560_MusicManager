using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetUserDataDelegate : DataReaderDelegate<User>
    {
        private readonly string email;
        private readonly string password;
        public GetUserDataDelegate(string email, string password) : base("LoginFetch")
        {
            this.email = email;
            this.password = password;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("Password", password);
        }
        public override User Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new User(
                reader.GetInt32("UserID"),
                reader.GetString("Name"),
                email,
                password);
        }
    }
}
