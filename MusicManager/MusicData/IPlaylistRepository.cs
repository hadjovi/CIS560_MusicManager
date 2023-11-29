using System.Collections.Generic;
using MusicData.Models;
namespace MusicData.Models
{
    public interface IPlaylistRepository
    {
        IReadOnlyList<Playlist> RetrievePlaylists(int ownerId);

        Playlist CreatePlaylist(string playlistName, int playistOwnerId, bool isPrivate, bool isDeleted);
    }
}
