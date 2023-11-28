using System;

namespace MusicManagerUI
{
    public class Album
    {
        public int AlbumID { get; }
        public string AlbumName { get; }

        public Album(int albumId, string albumName)
        {
            AlbumID = albumId;
            AlbumName = albumName;
        }
    }
}
