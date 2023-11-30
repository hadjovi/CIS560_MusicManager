using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveMostPopularGenresDataDelegate : DataReaderDelegate<IReadOnlyList<GenreWithSongs>>
    {
        public RetrieveMostPopularGenresDataDelegate() : base("GetMostPopularGenres")
        {
        }

        public override IReadOnlyList<GenreWithSongs> Translate(Command command, IDataRowReader reader)
        {
            var genres = new List<GenreWithSongs>();

            while (reader.Read())
            {
                genres.Add(new GenreWithSongs(
                    reader.GetInt32("GenreID"),
                    reader.GetString("GenreName"),
                    reader.GetInt32("NumberOfSongs")));
            }

            return genres;
        }
    }
}
