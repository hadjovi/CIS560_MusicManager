using MusicData.Models;
using MusicManagerUI.Models;
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
    public partial class SongAdd : Form
    {
        List<UiSong> allSongs = new();
        List<UiSong> trueSongs = new();
        UiSong selectedSong = null;
        public SongAdd(List<UiSong> S)
        {
            InitializeComponent();
        }

        private void uxTrySearch_Click(object sender, EventArgs e)
        {
            string trackName = uxSongNameBox.Text;
            string trackAlbumName = uxAlbumTitleBox.Text;
            string trackArtistName = uxArtistNameBox.Text;
            //Call search function here!!! have it return a list of songs?


            //then do this
            //uxResultBox.DataSource = trueSongs;

        }

        private void udAddButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in uxResultBox.SelectedRows)
            {
                selectedSong = row.DataBoundItem as UiSong;
            }
            //WHAT TO ACTUALLY DO WITH THE SONG





            DialogResult = DialogResult.OK;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
