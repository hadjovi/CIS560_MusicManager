using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrievePlaylistsDataDelegate : DataReaderDelegate<IReadOnlyList<Playlist>>
    {
        private readonly int ownerId;
        public RetrievePlaylistsDataDelegate(int ownerId) : base("RetrieveAllUserPlaylists")
        {
            this.ownerId = ownerId;
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
