using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class FetchSongDataDelegate : DataReaderDelegate<Song>
    {
        private readonly int songId;

        public FetchSongDataDelegate(int songId) : base("Song.FetchSong")
        {
            this.songId = songId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("SongID", SqlDbType.Int);
            p.Value = songId;
        }
        public override Song Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(songId.ToString());

            return new Song(songId,
                reader.GetString("SongName"),
                reader.GetInt32("Playtime"),
                reader.GetInt32("TrackNumber"),
                reader.GetInt32("GenreID"),
                reader.GetInt32("AlbumID"));
        }
    }
}
