using System;

namespace MusicData.Models
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
