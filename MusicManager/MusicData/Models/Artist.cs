using System;

namespace MusicData.Models
{
    public class Artist
    {
        public int ArtistID { get; }
        public string ArtistName { get; }
        public string ArtistLabel { get; }
        public string ArtistFirstName { get; }
        public string ArtistLastName { get; }

        public Artist(int artistId, string artistName, string artistLabel, string artistFirstName, string artistLastName)
        {
            ArtistID = artistId;
            ArtistName = artistName;
            ArtistLabel = artistLabel;
            ArtistFirstName = artistFirstName;
            ArtistLastName = artistLastName;
        }
    }
}
