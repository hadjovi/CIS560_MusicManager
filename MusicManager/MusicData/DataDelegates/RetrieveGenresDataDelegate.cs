using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveGenresDataDelegate : DataReaderDelegate<IReadOnlyList<Genre>>
    {
        public RetrieveGenresDataDelegate() : base("Genre.RetrieveGenre")
        {
        }

        public override IReadOnlyList<Genre> Translate(Command command, IDataRowReader reader)
        {
            var genres = new List<Genre>();

            while (reader.Read())
            {
                genres.Add(new Genre(
                    reader.GetInt32("GenreID"),
                    reader.GetString("GenreName")));
            }

            return genres;
        }
    }
}
