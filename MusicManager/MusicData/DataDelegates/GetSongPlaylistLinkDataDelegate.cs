using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetSongPlaylistLinkDataDelegate : DataReaderDelegate<SongPlaylistLink>
    {
        private readonly int playlistId;
        private readonly int songId;
        public GetSongPlaylistLinkDataDelegate(int playlistId, int songId) : base("SongPlaylistLink.GetSongPlaylistLink")
        {
            this.playlistId = playlistId;
            this.songId = songId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
            command.Parameters.AddWithValue("SongID", songId);
        }

        public override SongPlaylistLink Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new SongPlaylistLink(
                reader.GetInt32("LinkID"),
                playlistId,
                songId);
        }
    }
}
