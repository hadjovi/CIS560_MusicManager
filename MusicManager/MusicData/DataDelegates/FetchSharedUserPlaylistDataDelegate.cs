using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class FetchSharedUserPlaylistDataDelegate : DataReaderDelegate<SharedUserPlaylist>
    {
        private readonly int sharedUserPlaylistId;

        public FetchSharedUserPlaylistDataDelegate(int sharedUserPlaylistId) : base("SharedUserPlaylist.FetchSharedUserPlaylist")
        {
            this.sharedUserPlaylistId = sharedUserPlaylistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("SharedUserPlaylistID", SqlDbType.Int);
            p.Value = sharedUserPlaylistId;
        }
        public override SharedUserPlaylist Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(sharedUserPlaylistId.ToString());

            return new SharedUserPlaylist(sharedUserPlaylistId,
                reader.GetInt32("PlaylistID"),
                reader.GetInt32("UserID"));
        }
    }
}
