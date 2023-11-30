using MusicData.Models;
using DataAccess;

namespace MusicData.DataDelegates
{
    internal class DeleteSongFromPlaylistDataDelegate : DataDelegate
    {
        private readonly int songId;
        private readonly int playlistId;
        public DeleteSongFromPlaylistDataDelegate(int songId, int playlistId) : base("DeleteSongFromPlaylist")
        {
            this.songId = songId;
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlaylistID", playlistId);
            command.Parameters.AddWithValue("SongID", songId);
        }
    }
}
