using MusicData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class CreateSongDataDelegate : NonQueryDataDelegate<Song>
    {
        public readonly string songName;
        public readonly int playtime;
        public readonly int trackNumber;
        public readonly int genreId;
        public readonly int albumId;
        public CreateSongDataDelegate(string songName, int playtime, int trackNumber, int genreId, int albumId) : base("Song.CreateSong")
        {
            this.songName = songName;
            this.playtime = playtime;
            this.trackNumber = trackNumber;
            this.genreId = genreId;
            this.albumId = albumId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SongName", songName);
            command.Parameters.AddWithValue("Playtime", playtime);
            command.Parameters.AddWithValue("TrackNumber", trackNumber);
            command.Parameters.AddWithValue("GenreID", genreId);
            command.Parameters.AddWithValue("AlbumID", albumId);

            var p = command.Parameters.Add("SongID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Song Translate(Command command)
        {
            return new Song(command.GetParameterValue<int>("SongID"), songName, playtime, trackNumber, genreId, albumId);
        }
    }
}
