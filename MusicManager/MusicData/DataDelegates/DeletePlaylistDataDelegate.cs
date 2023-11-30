using MusicData.Models;
using DataAccess;
using System.Runtime.CompilerServices;
namespace MusicData.DataDelegates
{
    public class DeletePlaylistDataDelegate : DataDelegate
    {
        private readonly int userId;
        private readonly int playlistId;
        public DeletePlaylistDataDelegate(int userId, int playlistId) : base("DeleteOwnedPlaylist")
        {
            this.userId = userId;
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", userId);
            command.Parameters.AddWithValue("PlaylistID", playlistId);
        }
    }
}
