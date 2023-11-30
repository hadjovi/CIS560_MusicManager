using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicData.Models
{
    public class PlaylistWithPlaytime
    {
        public int PlaylistID { get; }
        public string PlaylistName { get; }
        public int NumberOfSong { get; }
        public int TotalPlaytime { get; }

        public PlaylistWithPlaytime(int playlistId, string playlistName, int numberofSong, int totalPlaytime)
        {
            this.PlaylistID = playlistId;
            this.PlaylistName = playlistName;
            this.NumberOfSong = numberofSong;
            this.TotalPlaytime = totalPlaytime;
        }
    }
}
