using System;

namespace MusicData.Models
{
    public class Song
    {
        public int SongID { get; }

        //seconds of playtime
        public int Playtime { get; }
        public int GenreID { get; }
        public int AlbumID { get; }
        public int TrackNumber { get; }

        public Song(int songId, int playtime, int genreId, int albumId, int trackNumber)
        {
            SongID = songId;
            Playtime = playtime;
            GenreID = genreId;
            AlbumID = albumId;
            TrackNumber = trackNumber;
        }
    }
}
