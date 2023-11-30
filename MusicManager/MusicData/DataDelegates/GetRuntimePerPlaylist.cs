using DataAccess;
using MusicData.Models;
using System.Data;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetRuntimePerPlaylist : DataReaderDelegate<PlaylistWithPlaytime>
    {
        private readonly int playlistId;

        public GetRuntimePerPlaylist(int playlistId) : base("ShowTotalRuntimePerPlaylist")
        {
            this.playlistId = playlistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PlaylistID", SqlDbType.Int);
            p.Value = playlistId;
        }
        public override PlaylistWithPlaytime Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(playlistId.ToString());

            return new PlaylistWithPlaytime(playlistId,
                reader.GetString("PlaylistName"),
                reader.GetInt32("NumberOfSong"),
                reader.GetInt32("TotalPlaytime"));
        }
    }
}
