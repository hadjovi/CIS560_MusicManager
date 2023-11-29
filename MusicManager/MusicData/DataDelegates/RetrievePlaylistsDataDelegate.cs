using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrievePlaylistsDataDelegate : DataReaderDelegate<IReadOnlyList<Playlist>>
    {
        private readonly int userId;
        public RetrievePlaylistsDataDelegate(int userId) : base("RetrieveAllUserPlaylists")
        {
            this.userId = userId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", userId);
        }
        public override IReadOnlyList<Playlist> Translate(Command command, IDataRowReader reader)
        {
            var playlists = new List<Playlist>();

            while (reader.Read())
            {
                playlists.Add(new Playlist(
                    reader.GetInt32("PlaylistID"),
                    reader.GetString("PlaylistName"),
                    reader.GetInt32("PlaylistOwnerID"),
                    reader.GetBoolean("IsPrivate"),
                    reader.GetBoolean("IsDeleted")));
            }

            return playlists;
        }
    }
}
