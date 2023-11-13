using System;

namespace MusicData.Models
{
    public class SongPlaylistLink
    {
        public int LinkID { get; }
        public int PlaylistID { get; }
        public int SongID { get; }

        public SongPlaylistLink(int linkId, int playlistId, int songId)
        {
            LinkID = linkId;
            PlaylistID = playlistId;
            SongID = songId;
        }
    }
}
