using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;


namespace MusicData.DataDelegates
{
    public class GetSongByTrackNumberDataDelegate : DataReaderDelegate<Song>
    {
        private readonly int trackNumber;
        private readonly int albumId;
        public GetSongByTrackNumberDataDelegate(int trackNumber, int albumId) : base("Song.GetSongByTrackNumber")
        {
            this.trackNumber = trackNumber;
            this.albumId = albumId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TrackNumber", trackNumber);
            command.Parameters.AddWithValue("AlbumID", albumId);
        }

        public override Song Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Song(
                reader.GetInt32("SongID"),
                reader.GetString("SongName"),
                reader.GetInt32("Playtime"),
                trackNumber,
                reader.GetInt32("GenreID"),
                albumId);
        }
    }
}
