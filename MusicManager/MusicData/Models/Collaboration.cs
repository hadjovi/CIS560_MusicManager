using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicData.Models
{
    public class Collaboration
    {
        public int ArtistID { get; }
        public string ArtistName { get; }
        public string AlbumName { get; }

        public Collaboration(int artistId, string artistName, string albumName)
        {
            this.ArtistID = artistId;
            this.ArtistName = artistName;
            this.AlbumName = albumName;
        }
    }
}
