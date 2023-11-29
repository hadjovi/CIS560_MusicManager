using System;
using MusicData.Models;


namespace MusicManagerUI.Models
{
    public class UiSong : Song
    {
        string ArtistName { get; set; }
        string AlbumName { get; set; }
        string GenreName { get; set; }
        public UiSong(int songId, string songName, int playtime, int trackNumber, int genreId, int albumId) : base(songId, songName, playtime, trackNumber, genreId, albumId)
        {
        }

        public UiSong(int songId, string songName, int playtime, int trackNumber, int genreId, int albumId, string artistName, string albumName, string genreName) : base(songId, songName, playtime, trackNumber, genreId, albumId)
        {
            ArtistName = artistName;
            AlbumName = albumName;
            GenreName = genreName;
        }
    }
}
