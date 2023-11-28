using MusicData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class CreateSongPlaylistLinkDataDelegate : NonQueryDataDelegate<SongPlaylistLink>
    {
        public readonly int playlistId;
        public readonly int songId;
        public CreateSongPlaylistLinkDataDelegate(int playlistId, int songId) : base("SongPlaylistLink.CreateSongPlaylistLink")
        {
            this.playlistId = playlistId;
            this.songId = songId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
            command.Parameters.AddWithValue("SongID", songId);

            var p = command.Parameters.Add("LinkID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }
        public override SongPlaylistLink Translate(Command command)
        {
            return new SongPlaylistLink(command.GetParameterValue<int>("LinkID"), playlistId, songId);
        }
    }
}
