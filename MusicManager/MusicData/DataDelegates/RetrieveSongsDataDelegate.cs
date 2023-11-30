using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveSongsDataDelegate : DataReaderDelegate<IReadOnlyList<Song>>
    {
        public RetrieveSongsDataDelegate() : base("RetrieveAllSongs")
        {
        }

        public override IReadOnlyList<Song> Translate(Command command, IDataRowReader reader)
        {
            var songs = new List<Song>();

            while(reader.Read())
            {
                songs.Add(new Song(
                    reader.GetInt32("SongID"),
                    reader.GetString("SongName"),
                    reader.GetInt32("Playtime"),
                    reader.GetInt32("TrackNumber"),
                    reader.GetInt32("GenreID"),
                    reader.GetInt32("AlbumID")));
            }

            return songs;
        }
    }
}
