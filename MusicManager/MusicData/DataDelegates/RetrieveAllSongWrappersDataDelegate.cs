using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveAllSongWrappersDataDelegate : DataReaderDelegate<IReadOnlyList<SongInfoWrapper>>
    {
        public RetrieveAllSongWrappersDataDelegate() : base("RetrieveAllSongsWithEverything")
        {
        }

        public override IReadOnlyList<SongInfoWrapper> Translate(Command command, IDataRowReader reader)
        {
            var songWrappers= new List<SongInfoWrapper>();

            while (reader.Read())
            {
                songWrappers.Add(new SongInfoWrapper(
                    reader.GetInt32("SongID"),
                    reader.GetString("SongName"),
                    reader.GetInt32("TrackNumber"),
                    reader.GetInt32("AlbumID"),
                    reader.GetString("AlbumName"),
                    reader.GetInt32("ArtistID"),
                    reader.GetString("ArtistName"),
                    reader.GetInt32("GenreID"),
                    reader.GetString("GenreName"),
                    reader.GetInt32("Playtime")));
            }

            return songWrappers;
        }
    }
}
