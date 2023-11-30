using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicData.Models
{
    public class GenreWithSongs : Genre
    {
        public int NumberOfSongs { get; }
        public GenreWithSongs(int genreId, string genreName, int numberOfSongs) : base(genreId, genreName)
        {
            NumberOfSongs = numberOfSongs;
        }
    }
}
