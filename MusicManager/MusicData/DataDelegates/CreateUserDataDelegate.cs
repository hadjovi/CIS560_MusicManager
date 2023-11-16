using MusicData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class CreateUserDataDelegate : NonQueryDataDelegate<User>
    {
        public readonly string name;
        public readonly string email;
        public readonly string password;

        public CreateUserDataDelegate(string name, string email, string password) : base("User.CreateUser")
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("Password", password);

            var p = command.Parameters.Add("UserID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override User Translate(Command command)
        {
            return new User(command.GetParameterValue<int>("UserID"), name, email, password);
        }
    }
}
