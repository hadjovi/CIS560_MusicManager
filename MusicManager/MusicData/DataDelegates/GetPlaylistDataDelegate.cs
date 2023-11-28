using DataAccess;
using MusicData.Models;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class GetPlaylistDataDelegate : DataReaderDelegate<Playlist>
    {
        public GetPlaylistDataDelegate(string procedureName) : base(procedureName)
        {
        }

        public override Playlist Translate(Command command, IDataRowReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}
