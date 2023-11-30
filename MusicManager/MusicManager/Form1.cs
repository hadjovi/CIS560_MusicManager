using MusicData;
using MusicData.Models;
using MusicManagerUI;
using MusicManagerUI.Models;

namespace MusicManager
{
    public partial class Form1 : Form
    {
        User SignedIn;
        User LibOwner;
        List<User> userList = new();
        List<Playlist> currentLibrary = new();
        Playlist currentPlaylist;
        List<Song> currentPlaylistSongs = new();
        List<Song> allSongList = new();
        List<SongInfoWrapper> SuperSongList = new();
        List<SongInfoWrapper> SuperCurrentPlaylistSongs = new();



        SqlUserRepository uRepo = new SqlUserRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");
        SqlPlaylistRepository pRepo = new SqlPlaylistRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");
        SqlSongRepository sRepo = new SqlSongRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");



        public Form1()
        {
            InitializeComponent();
            getUsers();


            IReadOnlyList<Song> readSong = sRepo.RetrieveSongs();
            foreach (Song s in readSong) { allSongList.Add(new Song(s.SongID, s.SongName, s.Playtime, s.TrackNumber, s.GenreID, s.AlbumID)); }

            loginDialog();
            setLibrary(SignedIn);
            uxPlaylists.Columns["PlaylistID"].Visible = false;
            uxPlaylists.Columns["PlaylistOwnerID"].Visible = false;
            uxPlaylists.Columns["IsPrivate"].Visible = false;
            uxPlaylists.Columns["isDeleted"].Visible = false;
            //uxPlaylists.ClearSelection();
            //uxSongslist.Columns["SongID"].Visible=false;
            //uxSongslist.Columns["TrackNumber"].Visible = false;
            
            IReadOnlyList<SongInfoWrapper> readExtras = sRepo.RetrieveSongExtras(); //------------------------------
            foreach(SongInfoWrapper s in readExtras)
            {
                SuperSongList.Add(new SongInfoWrapper(s.Song.SongID, s.Song.SongName, s.Song.TrackNumber, s.Song.AlbumID, s.AlbumName, s.ArtistID, s.ArtistName, s.Song.GenreID, s.GenreName, s.Song.Playtime));
            }

    }



        /// <summary>
        /// Returns User selected from Login Dialog
        /// </summary>
        /// <returns>User selected</returns>
        public void loginDialog()
        {
            LoginDialog LD = new LoginDialog(userList);
            LD.ShowDialog();
            if (LD.DialogResult == DialogResult.OK)
            {
                SignedIn = (User)LD.user;
                Text = "Music Manager - " + SignedIn.Name;
            }
            else
            {
                MessageBox.Show("Must complete login dialog", "Error");
                loginDialog();
            }
        }
        /// <summary>
        /// Sets left side of form (playlistView) to invisible
        /// </summary>
        public void setPlaylistViewInvisible()
        {
            //label5.Visible = false;
            //label6.Visible = false;
            //label7.Visible = false;
            //label8.Visible = false;
            uxPlaylistName.Visible = false;
            uxSongslist.Visible = false;
            uxAddSong.Visible = false;
            uxPlaylistOwnerName.Visible = false;

            uxNoPlaylistWarning.Visible = true;
        }
        /// <summary>
        /// Sets left side of form (playlistView) to visible
        /// </summary>
        public void setPlaylistViewVisible()
        {
            //label5.Visible = true;
            //label6.Visible = true;
            //label7.Visible = true;
            //label8.Visible = true;
            uxPlaylistName.Visible = true;
            uxSongslist.Visible = true;
            uxAddSong.Visible = true;
            uxPlaylistOwnerName.Visible = true;

            uxNoPlaylistWarning.Visible = false;
        }

        /// <summary>
        /// Call EVERY time to update or fetch users
        /// </summary>
        public void getUsers()
        {
            userList = new();
            IReadOnlyList<User> readUsers = uRepo.RetrieveUsers();
            foreach(User u in readUsers)
            {
                userList.Add(new User(u.UserID, u.Name, u.Email, u.Password));
            }
        }

        private void uxSearchUsers_Click(object sender, EventArgs e)
        {
            UserSearchDialog USD = new UserSearchDialog(userList);
            USD.ShowDialog();
            if (USD.DialogResult == DialogResult.OK)
            {
                setLibrary(USD.user);
            }
        }
        private void setLibrary(User u)
        {
            LibOwner = u;
            currentLibrary = new();//reset source

            IReadOnlyList<Playlist> readPlaylist= pRepo.RetrievePlaylists(u.UserID);
            foreach(Playlist p in readPlaylist)
            {
                if (u.UserID == SignedIn.UserID && !(p.IsDeleted))
                {
                    currentLibrary.Add(new Playlist(p.PlaylistID, p.PlaylistName, p.PlaylistOwnerID, p.IsPrivate, p.IsDeleted));
                }
            }
            foreach (Playlist p in readPlaylist)
            {
                if (!p.IsPrivate && (u.UserID != SignedIn.UserID) && !(p.IsDeleted))
                {
                    currentLibrary.Add(new Playlist(p.PlaylistID, p.PlaylistName, p.PlaylistOwnerID, p.IsPrivate, p.IsDeleted));
                }
            }

            uxPlaylists.DataSource = currentLibrary;
            if (currentLibrary.Count == 0)
            {
                setPlaylistViewInvisible();
            }
            uxLibraryOwnerName.Text = u + "'s Library";
        }
        private void uxMyPlaylists_Click(object sender, EventArgs e)
        {
            setLibrary(SignedIn);
        }

        private void uxSignOut_Click(object sender, EventArgs e)
        {
            loginDialog();
            setLibrary(SignedIn);
        }

        private void uxPlaylists_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in uxPlaylists.SelectedRows)
            {
                currentPlaylist = row.DataBoundItem as Playlist;
            }
            currentPlaylistSongs = new();

            IReadOnlyList<Song> readSong = pRepo.RetrieveSongsFromPlaylist(currentPlaylist.PlaylistID);

            foreach(Song s in readSong)
            {
                currentPlaylistSongs.Add(new Song(s.SongID, s.SongName, s.Playtime, s.TrackNumber, s.GenreID, s.AlbumID));
                SongInfoWrapper temp = SuperSongList.Find(x => x.Song.SongID == s.SongID);
                SuperCurrentPlaylistSongs.Add(temp);//-------------------------------------------------------------------
            }


            uxPlaylistName.Text = "Playlist Name: "+currentPlaylist.PlaylistName;
            uxPlaylistOwnerName.Text = "Is owned by: "+currentPlaylist.PlaylistOwnerID.ToString();// Convert to PLAYLIST OWNER NAME!!!!!!!!

            uxSongslist.DataSource = currentPlaylistSongs;
            uxSongslist.DataSource = SuperCurrentPlaylistSongs; //-----------------------------------------------------

            //uxSongslist.Columns["SongID"].Visible = false;
            //uxSongslist.Columns["TrackNumber"].Visible = false;

            uxSongslist.Columns["ArtistID"].Visible = false;
            uxSongslist.Columns["AlbumName"].HeaderText = "Album";
            uxSongslist.Columns["ArtistName"].HeaderText = "Artist";
            uxSongslist.Columns["GenreName"].HeaderText = "Genre";



            if (SignedIn.UserID == currentPlaylist.PlaylistOwnerID)
            {
                uxAddSong.Enabled = true;
                uxDeleteSong.Enabled = true;
            }
            else
            {
                uxAddSong.Enabled = false;
                uxDeleteSong.Enabled = false;
            }

            setPlaylistViewVisible();

            if(currentPlaylist.PlaylistOwnerID == SignedIn.UserID)
            {
                uxPlaylistSettings.Enabled = true;
            }
            else
            {
                uxPlaylistSettings.Enabled = false;
            }



            List<Playlist> TempLibrary = new();
            IReadOnlyList<Playlist> readPlaylist = pRepo.RetrievePlaylists(SignedIn.UserID);
            foreach (Playlist p in readPlaylist)
            {
                if (!p.IsPrivate && (p.PlaylistOwnerID != SignedIn.UserID) && !(p.IsDeleted))
                {
                    TempLibrary.Add(new Playlist(p.PlaylistID, p.PlaylistName, p.PlaylistOwnerID, p.IsPrivate, p.IsDeleted));
                }
            }
            bool Owned = false;
            foreach(Playlist p in TempLibrary)
            {
                if (p.PlaylistID == currentPlaylist.PlaylistID) Owned = true;
            }
            if (!Owned)
            {
                uxAddToLib.Enabled = true;
                uxRemovePlaylist.Enabled = false;
            }
            else
            {
                uxAddToLib.Enabled = false;
                uxRemovePlaylist.Enabled = true;
            }
        }

        private void uxAddSong_Click(object sender, EventArgs e)
        {
            SongAdd SAD = new SongAdd(allSongList,currentPlaylist);
            SAD.ShowDialog();
            if (SAD.DialogResult == DialogResult.OK)
            {
                uxSongslist.DataSource = null;
                currentPlaylistSongs = new();

                IReadOnlyList<Song> readSong = pRepo.RetrieveSongsFromPlaylist(currentPlaylist.PlaylistID);

                foreach (Song s in readSong)
                {
                    currentPlaylistSongs.Add(new Song(s.SongID, s.SongName, s.Playtime, s.TrackNumber, s.GenreID, s.AlbumID));
                }


                uxPlaylistName.Text = "Playlist Name: " + currentPlaylist.PlaylistName;
                uxPlaylistOwnerName.Text = "Is owned by: " + currentPlaylist.PlaylistOwnerID.ToString();// Convert to PLAYLIST OWNER NAME!!!!!!!!

                uxSongslist.DataSource = currentPlaylistSongs;
            }
        }

        private void uxStats_Click(object sender, EventArgs e)
        {

        }

        private void uxDeleteSong_Click(object sender, EventArgs e)
        {
            Song delSong = allSongList[0];
            foreach (DataGridViewRow row in uxSongslist.SelectedRows)
            {
                delSong = row.DataBoundItem as Song;
            }
            try
            {
                pRepo.DeleteSongFromPlaylist(delSong.SongID, currentPlaylist.PlaylistID);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            uxSongslist.DataSource = null;
            currentPlaylistSongs = new();

            IReadOnlyList<Song> readSong = pRepo.RetrieveSongsFromPlaylist(currentPlaylist.PlaylistID);

            foreach (Song s in readSong)
            {
                currentPlaylistSongs.Add(new Song(s.SongID, s.SongName, s.Playtime, s.TrackNumber, s.GenreID, s.AlbumID));
            }


            uxPlaylistName.Text = "Playlist Name: " + currentPlaylist.PlaylistName;
            uxPlaylistOwnerName.Text = "Is owned by: " + currentPlaylist.PlaylistOwnerID.ToString();// Convert to PLAYLIST OWNER NAME!!!!!!!!

            uxSongslist.DataSource = currentPlaylistSongs;
        }

        private void uxCreatePlaylist_Click(object sender, EventArgs e)
        {
            CreatePlaylistDialog CPD = new CreatePlaylistDialog();
            CPD.ShowDialog();
            if (CPD.DialogResult == DialogResult.OK)
            {
                pRepo.CreatePlaylist(CPD.playName, SignedIn.UserID, CPD.isPrivate, false);
            }
            setLibrary(SignedIn);
        }

        private void uxPlaylistSettings_Click(object sender, EventArgs e)
        {
            PlaylistSettingsDialog PS = new PlaylistSettingsDialog(currentPlaylist);
            PS.ShowDialog();
            setLibrary(SignedIn);
        }

        private void uxAddToLib_Click(object sender, EventArgs e)
        {
            pRepo.AddFriendPlaylist(currentPlaylist.PlaylistID, SignedIn.UserID);
            setLibrary(SignedIn);
        }

        private void uxRemovePlaylist_Click(object sender, EventArgs e)
        {
            pRepo.DeleteFriendPlaylist(currentPlaylist.PlaylistID, SignedIn.UserID);
            setLibrary(SignedIn);
        }
    }
}