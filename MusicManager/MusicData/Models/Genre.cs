using System;

namespace MusicData.Models
{
    public class Genre
    {
        public int GenreID { get; }
        public string GenreName { get; }
        
        public Genre(int genreId, string genreName)
        {
            GenreID = genreId;
            GenreName = genreName;
        }
    }
}
