using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;


namespace MusicData.DataDelegates
{
    public class GetSongByNameDataDelegate : DataReaderDelegate<Song>
    {
        private readonly string songName;
        private readonly int albumId;
        public GetSongByNameDataDelegate(string songName, int albumId) : base("Song.GetSongByName")
        {
            this.songName = songName;
            this.albumId = albumId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SongName", songName);
            command.Parameters.AddWithValue("AlbumID", albumId);
        }

        public override Song Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Song(
                reader.GetInt32("SongID"),
                songName,
                reader.GetInt32("Playtime"),
                reader.GetInt32("TrackNumber"),
                reader.GetInt32("GenreID"),
                albumId);
        }
    }
}
