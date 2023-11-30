using System;

namespace MusicData.Models
{
    public class SongInfoWrapper
    {
        public Song Song { get; }
        public int ArtistID { get; }
        public string AlbumName { get; }
        public string ArtistName { get; }
        public string GenreName { get; }

        public SongInfoWrapper(int songId, string songName, int trackNumber, int albumId, string albumName, int artistId, string artistName, int genreId, string genreName, int playtime)
        {
            this.Song = new Song(songId, songName, playtime, trackNumber, genreId, albumId);
            this.ArtistID = artistId;
            this.AlbumName = albumName;
            this.ArtistName = artistName;
            this.GenreName = genreName;
        }
    }
}
