using Microsoft.SqlServer.Server;
using MusicData;
using MusicData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MusicManagerUI
{
    public partial class StatsDisplayDialog : Form
    {
        List<Song> mostPopSongs = new();

        SqlAggregateQueryRepository aRepo = new SqlAggregateQueryRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");

        public StatsDisplayDialog()
        {
            InitializeComponent();
            IReadOnlyList<TopSong> readTop = aRepo.GetTop10Songs();
            string[] top = new string[10];
            int[] ind = new int[10];
            int i = 0;
            foreach(TopSong t in readTop)
            {
                top[i] = t.SongName;
                i++;
                ind[i - 1] = i;
            }
            uxSongBox.DataSource = top;
            uxIndBox.DataSource = ind;

            IReadOnlyList<GenreWithSongs> readGen = aRepo.GetMostPopularGenres();
            List<String> genres = new();
            //i = 0;
            foreach (GenreWithSongs t in readGen)
            {
                genres.Add( t.GenreName);
            }
            uxGenre.DataSource = genres;

        }

        private void uxSearchArtist_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(uxArtistBox.Text) is int)
                {
                    IReadOnlyList<Collaboration> readCollab = aRepo.RetrieveCollaborations(Int32.Parse(uxArtistBox.Text));
                    List<string> artistName = new();
                    foreach (Collaboration c in readCollab)
                    {
                        artistName.Add(c.ArtistName);
                    }
                    uxGenreBox.DataSource = artistName;
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaylistWithPlaytime readCollab = aRepo.ShowRuntimePerPlaylist(Int32.Parse(uxOriginality.Text));

            uxRuntime.Text = readCollab.PlaylistName + " has a runtime of: " + readCollab.TotalPlaytime.ToString();

        }

        private void uxRuntime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
