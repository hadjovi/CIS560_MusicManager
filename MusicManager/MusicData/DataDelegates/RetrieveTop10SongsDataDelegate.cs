using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveTop10SongsDataDelegate : DataReaderDelegate<IReadOnlyList<TopSong>>
    {
        public RetrieveTop10SongsDataDelegate() : base("GetTop10Songs")
        {
        }

        public override IReadOnlyList<TopSong> Translate(Command command, IDataRowReader reader)
        {
            var songs = new List<TopSong>();

            while (reader.Read())
            {
                songs.Add(new TopSong(reader.GetInt32("SongID"),
                    reader.GetString("SongName"),
                    reader.GetInt32("NumberOfPlaylist")));
            }

            return songs;
        }
    }
}
