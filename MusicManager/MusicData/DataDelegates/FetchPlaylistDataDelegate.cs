using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class FetchPlaylistDataDelegate : DataReaderDelegate<Playlist>
    {
        private readonly int playlistId;

        public FetchPlaylistDataDelegate(int playlistId) : base("Playlist.FetchPlaylist")
        {
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PlaylistID", SqlDbType.Int);
            p.Value = playlistId;
        }

        public override Playlist Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(playlistId.ToString());

            return new Playlist(playlistId,
                reader.GetString("PlaylistName"),
                reader.GetInt32("PlaylistOwnerID"),
                reader.GetBoolean("IsPrivate"),
                reader.GetBoolean("IsDeleted"));
        }

    }
}
