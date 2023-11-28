using System;

namespace MusicManagerUI
{
    public class ArtistsAlbum
    {
        public int ArtistsAlbumID { get; }
        public int AlbumID { get; }
        public int ArtistID { get; }

        public ArtistsAlbum(int artistsAlbumId, int albumId, int artistId)
        {
            ArtistsAlbumID = artistsAlbumId;
            AlbumID = albumId;
            ArtistsAlbumID = artistId;
        }
    }
}
