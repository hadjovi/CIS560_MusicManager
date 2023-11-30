﻿using MusicData.Models;
using System;
using System.Collections.Generic;
using DataAccess;
using MusicData.DataDelegates;

namespace MusicData
{
    public class SqlPlaylistRepository : IPlaylistRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPlaylistRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IReadOnlyList<Playlist> RetrievePlaylists(int userId)
        {
            return executor.ExecuteReader(new RetrievePlaylistsDataDelegate(userId));
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

        public IReadOnlyList<Song> RetrieveSongsFromPlaylist(int playlistId)
        {
            var d = new RetrieveAllSongsFromPlaylistDataDelegate(playlistId);
            return executor.ExecuteReader(d);
        }

        public void AddSongToPlaylist(int songId, int playlistId)
        {
            var d = new AddSongToPlaylistDataDelegate(songId, playlistId);
            executor.ExecuteNonQuery(d);
        }

        public void DeleteSongFromPlaylist(int songId, int playlistId)
        {
            var d = new DeleteSongFromPlaylistDataDelegate(songId, playlistId);
            executor.ExecuteNonQuery(d);
        }

        public void DeletePlaylist(int userId, int playlistId)
        {
            var d = new DeletePlaylistDataDelegate(userId, playlistId);
            executor.ExecuteNonQuery(d);
        }
    }
}
