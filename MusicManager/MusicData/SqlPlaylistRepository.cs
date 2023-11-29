using MusicData.Models;
using System;
using System.Collections.Generic;
using DataAccess;
using MusicData.DataDelegates;
using System.Security.Cryptography.Pkcs;

namespace MusicData
{
    public class SqlPlaylistRepository : IPlaylistRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPlaylistRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IReadOnlyList<Playlist> RetrievePlaylists(int ownerId)
        {
            return executor.ExecuteReader(new RetrievePlaylistsDataDelegate(ownerId));
        }

        public Playlist CreatePlaylist(string playlistName, int playlistOwnerId, bool isPrivate, bool isDeleted)
        {
            if (string.IsNullOrWhiteSpace(playlistName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(playlistName));

            var d = new CreatePlaylistDataDelegate(playlistName, playlistOwnerId, isPrivate, isDeleted);
            return executor.ExecuteNonQuery(d);
        }

        public void SetOwnedPlaylistPublic(int ownerId, int playlistId, string action)
        {
            var d = new PlaylistUpdateIsPrivateDataDelegate(ownerId, playlistId, action);
            executor.ExecuteNonQuery(d);
        }
    }
}
