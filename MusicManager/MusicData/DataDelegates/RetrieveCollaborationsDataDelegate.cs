using DataAccess;
using MusicData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicData.DataDelegates
{
    public class RetrieveCollaborationsDataDelegate : DataReaderDelegate<IReadOnlyList<Collaboration>>
    {
        private readonly int artistId;
        public RetrieveCollaborationsDataDelegate(int artistId) : base("ShowCollaboration")
        {
            this.artistId = artistId;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ArtistID", artistId);
        }

        public override IReadOnlyList<Collaboration> Translate(Command command, IDataRowReader reader)
        {
            var collabs = new List<Collaboration>();

            while (reader.Read())
            {
                collabs.Add(new Collaboration(
                    reader.GetInt32("ArtistID"),
                    reader.GetString("ArtistName"),
                    reader.GetString("AlbumName")));
            }

            return collabs;
        }
    }
}