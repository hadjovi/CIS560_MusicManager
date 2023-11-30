using MusicData.Models;
using System;
using System.Collections.Generic;
using DataAccess;
using MusicData.DataDelegates;

namespace MusicData
{
    public class SqlAggregateQueryRepository : IAggregateQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAggregateQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IReadOnlyList<GenreWithSongs> GetMostPopularGenres()
        {
            return executor.ExecuteReader(new RetrieveMostPopularGenresDataDelegate());
        }

        public IReadOnlyList<TopSong> GetTop10Songs()
        {
            return executor.ExecuteReader(new RetrieveTop10SongsDataDelegate());
        }

        public IReadOnlyList<Collaboration> RetrieveCollaborations(int artistId)
        {
            return executor.ExecuteReader(new RetrieveCollaborationsDataDelegate(artistId));
        }

        public PlaylistWithPlaytime ShowRuntimePerPlaylist(int playlistId)
        {
            var d = new GetRuntimePerPlaylist(playlistId);
            return executor.ExecuteReader(d);
        }
    }
}
