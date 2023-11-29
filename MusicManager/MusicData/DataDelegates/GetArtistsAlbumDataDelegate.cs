using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetArtistsAlbumDataDelegate : DataReaderDelegate<ArtistsAlbum>
    {
        private readonly int albumId;
        private readonly int artistId;
        public GetArtistsAlbumDataDelegate(int albumId, int artistId) : base("ArtistsAlbum.GetArtistsAlbum")
        {
            this.albumId = albumId;
            this.artistId = artistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumID", albumId);
            command.Parameters.AddWithValue("ArtistID", artistId);
        }

        public override ArtistsAlbum Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new ArtistsAlbum(
                reader.GetInt32("ArtistsAlbumID"),
                albumId,
                artistId);
        }
    }
}
