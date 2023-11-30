using System.Collections.Generic;
using MusicData.Models;

namespace MusicData
{
    public interface ISongRepository
    {
        IReadOnlyList<Song> RetrieveSongs();
    }
}
