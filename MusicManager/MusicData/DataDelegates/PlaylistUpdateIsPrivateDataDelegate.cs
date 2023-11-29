using MusicData.Models;
using DataAccess;

namespace MusicData.DataDelegates
{
    public class PlaylistUpdateIsPrivateDataDelegate : DataDelegate
    {
        private readonly int userId;
        private readonly int playlistId;
        public PlaylistUpdateIsPrivateDataDelegate(int userId, int playlistId, string procedureName) : base(procedureName)
        {
            this.userId = userId;
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistOwnerID", userId);
            command.Parameters.AddWithValue("PlaylistID", playlistId);
        }
    }
}
