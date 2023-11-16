using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetUserDataDelegate : DataReaderDelegate<User>
    {
        private readonly string email;
        public GetUserDataDelegate(string email) : base("User.GetPerson")
        {
            this.email = email;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Email", email);
        }
        public override User Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new User(
                reader.GetInt32("UserID"),
                reader.GetString("Name"),
                email,
                reader.GetString("Password"));
        }
    }
}
