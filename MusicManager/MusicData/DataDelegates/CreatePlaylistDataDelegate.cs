using MusicData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class CreatePlaylistDataDelegate : NonQueryDataDelegate<Playlist>
    {
        public readonly string playlistName;
        public readonly int playlistOwnerId;
        public readonly bool isPrivate;
        public readonly bool isDeleted;

        public CreatePlaylistDataDelegate(string playlistName, int playlistOwnerId, bool isPrivate, bool isDeleted) : base("Playlist.CreatePlaylist")
        {
            this.playlistName = playlistName;
            this.playlistOwnerId = playlistOwnerId;
            this.isPrivate = isPrivate;
            this.isDeleted = isDeleted;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistName", playlistName);
            command.Parameters.AddWithValue("PlaylistOwnerID", playlistOwnerId);
            command.Parameters.AddWithValue("IsPrivate", isPrivate);
            command.Parameters.AddWithValue("IsDeleted", isDeleted);

            var p = command.Parameters.Add("PlaylistID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Playlist Translate(Command command)
        {
            return new Playlist(command.GetParameterValue<int>("PlaylistID"), playlistName, playlistOwnerId, isPrivate, isDeleted);
        }
    }
}
