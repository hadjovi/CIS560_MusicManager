using System;

namespace MusicManagerUI
{
    public class SharedUserPlaylist
    {
        public int SharedUserPlaylistID { get; }
        public int PlaylistID { get; }
        public int UserID { get; }

        public SharedUserPlaylist(int sharedUserPlaylistId, int playlistId, int userId)
        {

            SharedUserPlaylistID = sharedUserPlaylistId;
            PlaylistID = playlistId;
            UserID = userId;
        }
    }
}
