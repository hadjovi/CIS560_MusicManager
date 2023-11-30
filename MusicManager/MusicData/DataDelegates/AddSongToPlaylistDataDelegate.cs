using MusicData.Models;
using DataAccess;

namespace MusicData.DataDelegates
{
    internal class AddSongToPlaylistDataDelegate : DataDelegate
    {
        private readonly int songId;
        private readonly int playlistId;
        public AddSongToPlaylistDataDelegate(int songId, int playlistId) : base("AddSongToPlaylist")
        {
            this.songId = songId;
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SongID", songId);
            command.Parameters.AddWithValue("PlaylistID", playlistId);
        }
    }
}
