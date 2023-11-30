using DataAccess;
using MusicData.DataDelegates;
using MusicData.Models;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace MusicData
{
    public class SqlSongRepository : ISongRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlSongRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IReadOnlyList<Song> RetrieveSongs()
        {
            return executor.ExecuteReader(new RetrieveSongsDataDelegate());
        }

        public IReadOnlyList<SongInfoWrapper> RetrieveSongExtras()
        {
            return executor.ExecuteReader(new RetrieveAllSongWrappersDataDelegate());
        }
    }
}
