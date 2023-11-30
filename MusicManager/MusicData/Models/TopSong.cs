using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicData.Models
{
    public class TopSong
    {
        public int SongID { get; }
        public string SongName { get; }
        public int NumberOfPlaylist { get; }

        public TopSong(int songId, string songName, int numberOfPlaylist)
        {
            this.SongID = songId;
            this.SongName = songName;
            this.NumberOfPlaylist = numberOfPlaylist;
        }
    }
}
