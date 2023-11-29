using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetGenreDataDelegate : DataReaderDelegate<Genre>
    {
        private readonly string genreName;
        public GetGenreDataDelegate(string genreName) : base("Genre.GetGenre")
        {
            this.genreName = genreName;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GenreName", genreName);
        }
        public override Genre Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Genre(
                reader.GetInt32("GenreID"),
                genreName);
        }
    }
}
