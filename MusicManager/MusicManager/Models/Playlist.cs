using System;

namespace MusicManagerUI
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


        /*
        public Playlist(string PlaylistName, int OwnerUserID, bool IsPrivate, bool IsDelete)
        {
            playlistName = PlaylistName;
            ownerUserID = OwnerUserID;
            isPrivate = IsPrivate;
            isDelete = IsDelete;
            //decide how to fetch OwnerName, sql? then pass in as a param??
            ownerName = "___FIX ME___";
        }

        //Should have a constructor in order to MAKE playlists
        */
    }
}
