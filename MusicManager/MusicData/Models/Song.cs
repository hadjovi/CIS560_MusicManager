using System;

namespace MusicData.Models
{
    public class Song
    {
        public int SongID { get; }
        public string SongName { get; }
        //seconds of playtime
        public int Playtime { get; }
        public int TrackNumber { get; }
        public int GenreID { get; }
        public int AlbumID { get; }

        public Song(int songId, string songName, int playtime, int trackNumber, int genreId, int albumId)
        {
            SongID = songId;
            SongName = songName;
            Playtime = playtime;
            GenreID = genreId;
            AlbumID = albumId;
            TrackNumber = trackNumber;
        }
        public override string ToString()
        {
            return SongName;
        }
    }
}
