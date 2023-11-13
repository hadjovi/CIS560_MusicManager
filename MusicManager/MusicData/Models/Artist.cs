using System;

namespace MusicData.Models
{
    public class Artist
    {
        public int ArtistID { get; }
        public string ArtistName { get; }
        public string ArtistLabel { get; }
        public string ArtistRealName { get; }

        public Artist(int artistId, string artistName, string artistLabel, string artistRealName)
        {
            ArtistID = artistId;
            ArtistName = artistName;
            ArtistLabel = artistLabel;
            ArtistRealName = artistRealName;
        }
    }
}
