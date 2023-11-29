using MusicData.Models;
using DataAccess;
using System.ComponentModel;

namespace MusicData.DataDelegates
{
    public class SavePlaylistDataDelegate : DataDelegate
    {
        private readonly int playlistId;
        private readonly string playlistName;
        private readonly int playlistOwnerId;
        private readonly bool isPrivate;
        private readonly bool isDeleted;
        public SavePlaylistDataDelegate(int playlistId, string playlistName, int playlistOwnerId, bool isPrivate, bool isDeleted) : base("Playlist.SavePlaylist")
        {
            this.playlistId = playlistId;
            this.playlistName = playlistName;
            this.playlistOwnerId = playlistOwnerId;
            this.isPrivate = isPrivate;
            this.isDeleted = isDeleted;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
            command.Parameters.AddWithValue("PlaylistName", playlistName);
            command.Parameters.AddWithValue("PlaylistOwnerID", playlistOwnerId);
            command.Parameters.AddWithValue("IsPrivate", isPrivate);
            command.Parameters.AddWithValue("IsDeleted", isDeleted);
        }
    }
}
