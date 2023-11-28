using MusicData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class CreateSharedUserPlaylistDataDelegate : NonQueryDataDelegate<SharedUserPlaylist>
    {
        public readonly int playlistId;
        public readonly int userId;

        public CreateSharedUserPlaylistDataDelegate(int playlistId, int userId) : base("SharedUserPlaylist.CreateSharedUserPlaylist")
        {
            this.playlistId = playlistId;
            this.userId = userId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
            command.Parameters.AddWithValue("UserID", userId);

            var p = command.Parameters.Add("SharedUserPlaylistID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }
        public override SharedUserPlaylist Translate(Command command)
        {
            return new SharedUserPlaylist(command.GetParameterValue<int>("SharedUserPlaylistID"), playlistId, userId);
        }
    }
}
