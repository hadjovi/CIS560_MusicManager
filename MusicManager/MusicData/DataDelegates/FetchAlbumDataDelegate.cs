using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;
namespace MusicData.DataDelegates
{
    public class FetchAlbumDataDelegate : DataReaderDelegate<Album>
    {
        private readonly int albumId;
        public FetchAlbumDataDelegate(int albumId) : base("Album.FetchAlbum")
        {
            this.albumId = albumId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("AlbumID", SqlDbType.Int);
            p.Value = albumId;
        }
        public override Album Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(albumId.ToString());

            return new Album(albumId,
                reader.GetString("AlbumName"));
        }
    }
}
