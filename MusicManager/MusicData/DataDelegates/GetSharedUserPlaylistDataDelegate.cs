using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetSharedUserPlaylistDataDelegate : DataReaderDelegate<SharedUserPlaylist>
    {
        private readonly int playlistId;
        private readonly int userId;
        public GetSharedUserPlaylistDataDelegate(int playlistId, int userId) : base("SharedUserPlaylist.GetSharedUserPlaylist")
        {
            this.playlistId = playlistId;
            this.userId = userId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
            command.Parameters.AddWithValue("UserID", userId);
        }

        public override SharedUserPlaylist Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new SharedUserPlaylist(
                reader.GetInt32("UserID"),
                playlistId,
                userId);
        }
    }
}
