using MusicData;
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
        SqlPlaylistRepository pRepo = new SqlPlaylistRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");


        public SongAdd(List<Song> S, Playlist p)
        {
            InitializeComponent();
            allSongs = S;
            currPlaylist = p;
            uxAddButton.Enabled = false;
        }

        private void uxTrySearch_Click(object sender, EventArgs e)
        {

            string trackName = uxSongNameBox.Text;
            string trackAlbumName = uxAlbumTitleBox.Text;
            string trackArtistName = uxArtistNameBox.Text;
            trueSongs = new();
            foreach (Song s in allSongs)
            {
                if (s.SongName.ToLower().Contains(trackName.ToLower())){//add other parameters
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
                uxResultBox.Columns["SongID"].Visible = false;
                //uxResultBox.Columns["TrackNumber"].Visible = false;
                //uxResultBox.Columns["GenreID"].Visible = false;
                //uxResultBox.Columns["AlbumID"].Visible = false;

            }


        }

        private void udAddButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in uxResultBox.SelectedRows)
            {
                selectedSong = row.DataBoundItem as Song;
            }
            try
            {
                pRepo.AddSongToPlaylist(selectedSong.SongID, currPlaylist.PlaylistID);
            }
            catch
            {
                MessageBox.Show("Cannot add duplicate songs");
            }
            DialogResult = DialogResult.OK;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
