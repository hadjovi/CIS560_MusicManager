using MusicData.Models;
using DataAccess;
using System.Runtime.CompilerServices;
namespace MusicData.DataDelegates
{
    public class DeleteFriendPlaylistDataDelegate : DataDelegate
    {
        private readonly int userId;
        private readonly int playlistId;
        public DeleteFriendPlaylistDataDelegate(int playlistId, int userId) : base("DeleteFriendPlaylist")
        {
            this.userId = userId;
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
            command.Parameters.AddWithValue("UserID", userId);
        }
    }
}
