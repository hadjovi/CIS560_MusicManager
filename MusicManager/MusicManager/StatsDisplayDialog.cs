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

namespace MusicManagerUI
{
    public partial class StatsDisplayDialog : Form
    {
        List<Song> mostPopSongs = new();

        public StatsDisplayDialog(List<Song> mps)
        {
            InitializeComponent();

        }

        private void uxSearchArtist_Click(object sender, EventArgs e)
        {

        }
    }
}
