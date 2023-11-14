using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class FetchUserDataDelegate : DataReaderDelegate<User>
    {
        private readonly int userId;

        public FetchUserDataDelegate(int userId) : base("User.FetchUser")
        {
            this.userId = userId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("UserID", SqlDbType.Int);
            p.Value = userId;
        }
        public override User Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(userId.ToString());

            return new User(userId,
                reader.GetString("Name"),
                reader.GetString("Email"),
                reader.GetString("Password"));
        }
    }
}
