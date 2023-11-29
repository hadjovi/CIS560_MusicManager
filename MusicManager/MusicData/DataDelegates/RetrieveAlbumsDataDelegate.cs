using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveAlbumsDataDelegate : DataReaderDelegate<IReadOnlyList<Album>>
    {
        public RetrieveAlbumsDataDelegate() : base("Album.RetrieveAlbum")
        {
        }

        public override IReadOnlyList<Album> Translate(Command command, IDataRowReader reader)
        {
            var albums = new List<Album>();

            while (reader.Read())
            {
                albums.Add(new Album(
                    reader.GetInt32("AlbumID"),
                    reader.GetString("AlbumName")));
            }

            return albums;
        }
    }
}
