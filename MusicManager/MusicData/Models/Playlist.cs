using System;

namespace MusicData.Models
{
    public class Playlist
    {
        public int PlaylistID { get; }
        public int OwnerUserID { get; }
        public bool IsPrivate { get; }
        public bool IsDelete { get; }

        public Playlist(int playlistId, int ownerUserId, bool isPrivate, bool isDelete)
        {
            PlaylistID = playlistId;
            OwnerUserID = ownerUserId;
            IsPrivate = isPrivate;
            IsDelete = isDelete;
        }
    }
}
