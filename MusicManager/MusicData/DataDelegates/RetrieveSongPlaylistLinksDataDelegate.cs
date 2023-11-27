using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveSongPlaylistLinksDataDelegate : DataReaderDelegate<IReadOnlyList<SongPlaylistLink>>
    {
        public RetrieveSongPlaylistLinksDataDelegate() : base("SongPlaylistLink.RetrieveSongPlaylistLink")
        {
        }

        public override IReadOnlyList<SongPlaylistLink> Translate(Command command, IDataRowReader reader)
        {
            var playlists = new List<SongPlaylistLink>();

            while (reader.Read())
            {
                playlists.Add(new SongPlaylistLink(
                    reader.GetInt32("LinkID"),
                    reader.GetInt32("PlaylistID"),
                    reader.GetInt32("SongID")));
            }

            return playlists;
        }
    }
}
