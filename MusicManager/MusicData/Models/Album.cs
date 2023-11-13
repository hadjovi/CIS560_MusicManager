using System;

namespace MusicData.Models
{
    public class Album
    {
        public int AlbumID { get; }
        public string AlbumName { get; }
        public int ArtistsAlbumID { get; }

        public Album(int albumId, string albumName, int artistsAlbumId)
        {
            AlbumID = albumId;
            AlbumName = albumName;
            ArtistsAlbumID = artistsAlbumId;
        }
    }
}
