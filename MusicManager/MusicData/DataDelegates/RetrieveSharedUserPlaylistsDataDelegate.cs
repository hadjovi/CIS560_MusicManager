using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveSharedUserPlaylistsDataDelegate : DataReaderDelegate<IReadOnlyList<SharedUserPlaylist>>
    {
        public RetrieveSharedUserPlaylistsDataDelegate() : base("SharedUserPlaylist.RetrieveSharedUserPlaylist")
        {
        }

        public override IReadOnlyList<SharedUserPlaylist> Translate(Command command, IDataRowReader reader)
        {
            var sharedPlaylists = new List<SharedUserPlaylist>();

            while(reader.Read())
            {
                sharedPlaylists.Add(new SharedUserPlaylist(
                    reader.GetInt32("SharedUserPlaylistID"),
                    reader.GetInt32("PlaylistID"),
                    reader.GetInt32("UserID")));
            }

            return sharedPlaylists;
        }
    }
}
