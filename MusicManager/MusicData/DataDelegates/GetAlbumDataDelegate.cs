using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetAlbumDataDelegate : DataReaderDelegate<Album>
    {
        private readonly string albumName;
        public GetAlbumDataDelegate(string albumName) : base("Album.GetAlbum")
        {
            this.albumName = albumName;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AlbumName", albumName);
        }
        public override Album Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Album(
                reader.GetInt32("AlbumID"),
                albumName);
        }
    }
}
