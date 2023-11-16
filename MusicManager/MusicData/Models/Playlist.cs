using System;

namespace MusicData.Models
{
    public class Playlist
    {
        public int PlaylistID { get; }
        public string PlaylistName { get; }
        public int PlaylistOwnerID { get; }
        public bool IsPrivate { get; }
        public bool IsDeleted { get; }

        public Playlist(int playlistId, string playlistName, int playlistOwnerId, bool isPrivate, bool isDeleted)
        {
            PlaylistID = playlistId;
            PlaylistName = playlistName;
            PlaylistOwnerID = playlistOwnerId;
            IsPrivate = isPrivate;
            IsDeleted = isDeleted;
        }
    }
}
