﻿using System;

namespace MusicManagerUI
{
    public class Playlist
    {
        public int PlaylistID { get; }
        public string PlaylistName { get; }
        public int PlaylistOwnerID { get; }
        public bool IsPrivate { get; }
        public bool IsDeleted { get; }

        /// <summary>
        /// Constructor to input data from SQL
        /// </summary>
        /// <param name="playlistId"></param>
        /// <param name="playlistName"></param>
        /// <param name="playlistOwnerId"></param>
        /// <param name="isPrivate"></param>
        /// <param name="isDeleted"></param>
        public Playlist(int playlistId, string playlistName, int playlistOwnerId, bool isPrivate, bool isDeleted)
        {
            PlaylistID = playlistId;
            PlaylistName = playlistName;
            PlaylistOwnerID = playlistOwnerId;
            IsPrivate = isPrivate;
            IsDeleted = isDeleted;
        }

        /// <summary>
        /// Constructor to make playlists in SQL
        /// </summary>
        /// <param name="playlistName"></param>
        /// <param name="playlistOwnerID"></param>
        /// <param name="isPrivate"></param>
        public Playlist(string playlistName, int playlistOwnerID, bool isPrivate)
        {
            //Need to set playlist ID right below this ??----------------------------------------------------------------------
            PlaylistName = playlistName;
            PlaylistOwnerID = playlistOwnerID;
            IsPrivate = isPrivate;
            IsDeleted = false;
        }
    }
}
