using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveArtistsAlbumsDataDelegate : DataReaderDelegate<IReadOnlyList<ArtistsAlbum>>
    {
        public RetrieveArtistsAlbumsDataDelegate() : base("ArtistsAlbum.RetrieveArtistsAlbum")
        {
        }

        public override IReadOnlyList<ArtistsAlbum> Translate(Command command, IDataRowReader reader)
        {
            var artistAlbums = new List<ArtistsAlbum>();

            while (reader.Read())
            {
                artistAlbums.Add(new ArtistsAlbum(
                    reader.GetInt32("ArtistsAlbumID"),
                    reader.GetInt32("AlbumID"),
                    reader.GetInt32("ArtistID")));
            }

            return artistAlbums;
        }
    }
}
