using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class FetchSongPlaylistLinkDataDelegate : DataReaderDelegate<SongPlaylistLink>
    {
        private readonly int linkId;
        public FetchSongPlaylistLinkDataDelegate(int linkId) : base("SongPlaylistLink.FetchSongPlaylistLink")
        {
            this.linkId = linkId;
        }
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("LinkID", SqlDbType.Int);
            p.Value = linkId;
        }
        public override SongPlaylistLink Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(linkId.ToString());

            return new SongPlaylistLink(linkId,
                reader.GetInt32("PlaylistID"),
                reader.GetInt32("SongID"));
        }
    }
}
