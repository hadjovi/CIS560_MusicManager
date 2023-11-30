using System.Collections.Generic;
using MusicData.Models;

namespace MusicData.DataDelegates
{
    public interface IAggregateQueryRepository
    {
        IReadOnlyList<GenreWithSongs> GetMostPopularGenres();

        IReadOnlyList<Collaboration> RetrieveCollaborations(int artistId);

        PlaylistWithPlaytime ShowRuntimePerPlaylist(int playlistId);

        IReadOnlyList<TopSong> GetTop10Songs();
    }
}
