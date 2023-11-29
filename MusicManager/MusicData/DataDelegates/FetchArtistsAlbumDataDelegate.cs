using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class FetchArtistsAlbumDataDelegate : DataReaderDelegate<ArtistsAlbum>
    {
        private readonly int artistsAlbumId;

        public FetchArtistsAlbumDataDelegate(int artistsAlbumId) : base("ArtistsAlbum.FetchArtistsAlbum")
        {
            this.artistsAlbumId = artistsAlbumId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ArtistsAlbumID", SqlDbType.Int);
            p.Value = artistsAlbumId;
        }
        public override ArtistsAlbum Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(artistsAlbumId.ToString());

            return new ArtistsAlbum(artistsAlbumId,
                reader.GetInt32("AlbumID"),
                reader.GetInt32("ArtistID"));
        }
    }
}
