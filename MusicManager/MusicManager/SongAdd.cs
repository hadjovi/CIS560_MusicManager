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
        List<Song> allSongs = new();
        List<Song> trueSongs = new();
        Song selectedSong;
        Playlist currPlaylist;
        public SongAdd(List<Song> S, Playlist p)
        {
            InitializeComponent();
            allSongs = S;
            currPlaylist = p;
        }

        private void uxTrySearch_Click(object sender, EventArgs e)
        {

            string trackName = uxSongNameBox.Text;
            string trackAlbumName = uxAlbumTitleBox.Text;
            string trackArtistName = uxArtistNameBox.Text;
            //Call search function here!!! have it return a list of songs?
            trueSongs = new();
            foreach (Song s in trueSongs)
            {
                if (s.SongName.ToLower().Contains(uxSongNameBox.Text.ToLower())){//add other parameters
                    trueSongs.Add(s);
                }
            }
            uxResultBox.DataSource = trueSongs;
            if (trueSongs.Count == 0)
            {
                uxAddButton.Enabled = false;
            }
            else
            {
                uxAddButton.Enabled = true;
            }


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
