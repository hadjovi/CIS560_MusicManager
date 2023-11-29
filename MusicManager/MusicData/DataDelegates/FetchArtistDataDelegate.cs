using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class FetchArtistDataDelegate : DataReaderDelegate<Artist>
    {
        private readonly int artistId;
        public FetchArtistDataDelegate(int artistId) : base("Artist.FetchArtist")
        {
            this.artistId = artistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ArtistID", SqlDbType.Int);
            p.Value = artistId;
        }

        public override Artist Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(artistId.ToString());

            return new Artist(artistId,
                reader.GetString("ArtistName"),
                reader.GetString("ArtistLabel"),
                reader.GetString("ArtistFirstName"),
                reader.GetString("ArtistLastName"));
        }
    }
}
