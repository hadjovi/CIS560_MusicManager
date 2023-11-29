using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveAllSongsFromPlaylistDataDelegate : DataReaderDelegate<IReadOnlyList<Song>>
    {
        private readonly int playlistId;
        public RetrieveAllSongsFromPlaylistDataDelegate(int playlistId) : base("RetrieveSongsFromPlaylist")
        {
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
        }
        public override IReadOnlyList<Song> Translate(Command command, IDataRowReader reader)
        {
            var songs = new List<Song>();

            while (reader.Read())
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
