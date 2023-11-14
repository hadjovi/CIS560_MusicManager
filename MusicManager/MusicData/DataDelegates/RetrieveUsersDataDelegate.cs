using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveUsersDataDelegate : DataReaderDelegate<IReadOnlyList<User>>
    {
        public RetrieveUsersDataDelegate(string procedureName) : base("User.RetrieveUser")
        {
        }

        public override IReadOnlyList<User> Translate(Command command, IDataRowReader reader)
        {
            var users = new List<User>();

            while (reader.Read())
            {
                users.Add(new User(
                    reader.GetInt32("UserID"),
                    reader.GetString("Name"),
                    reader.GetString("Email"),
                    reader.GetString("Password")));
            }

            return users;
        }
    }
}
