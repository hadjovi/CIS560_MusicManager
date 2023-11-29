using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveArtistsDataDelegate : DataReaderDelegate<IReadOnlyList<Artist>>
    {
        public RetrieveArtistsDataDelegate() : base("Artists.RetrieveArtists")
        {
        }

        public override IReadOnlyList<Artist> Translate(Command command, IDataRowReader reader)
        {
            var artists = new List<Artist>();

            while (reader.Read())
            {
                artists.Add(new Artist(
                    reader.GetInt32("ArtistID"),
                    reader.GetString("ArtistName"),
                    reader.GetString("ArtistLabel"),
                    reader.GetString("ArtistFirstName"),
                    reader.GetString("ArtistLastName")));
            }

            return artists;
        }
    }
}
