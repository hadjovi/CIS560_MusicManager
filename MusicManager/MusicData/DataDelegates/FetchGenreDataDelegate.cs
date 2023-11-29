using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;
namespace MusicData.DataDelegates
{
    public class FetchGenreDataDelegate : DataReaderDelegate<Genre>
    {
        private readonly int genreId;
        public FetchGenreDataDelegate(int genreId) : base("Genre.FetchGenre")
        {
            this.genreId = genreId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("GenreID", SqlDbType.Int);
            p.Value = genreId;
        }
        public override Genre Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(genreId.ToString());

            return new Genre(genreId,
                reader.GetString("GenreName"));
        }
    }
}
