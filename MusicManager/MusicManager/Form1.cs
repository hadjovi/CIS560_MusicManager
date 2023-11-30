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
        Playlist currentPlaylist;//check
        List<Song> currentPlaylistSongs = new();
        //List<UiSong> allSongList = new();//check

        SqlUserRepository uRepo = new SqlUserRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");
        SqlPlaylistRepository pRepo = new SqlPlaylistRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");

        public Form1()
        {
            InitializeComponent();
            setPlaylistViewInvisible();
            getUsers();


            loginDialog();
            setLibrary(SignedIn);
            uxPlaylists.Columns["PlaylistID"].Visible = false;
            uxPlaylists.Columns["PlaylistOwnerID"].Visible = false;
            uxPlaylists.Columns["IsPrivate"].Visible = false;
            uxPlaylists.Columns["isDeleted"].Visible = false;
            uxPlaylists.ClearSelection();
            //uxSongslist.Columns["SongID"].Visible=false;
            //uxSongslist.Columns["TrackNumber"].Visible = false;
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
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
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
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
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
                if (u.UserID == SignedIn.UserID)
                {
                    currentLibrary.Add(new Playlist(p.PlaylistID, p.PlaylistName, p.PlaylistOwnerID, p.IsPrivate, p.IsDeleted));
                }
            }
            foreach (Playlist p in readPlaylist)
            {
                if (!p.IsPrivate && u.UserID != SignedIn.UserID)
                {
                    currentLibrary.Add(new Playlist(p.PlaylistID, p.PlaylistName, p.PlaylistOwnerID, p.IsPrivate, p.IsDeleted));
                }
            }
            uxPlaylists.DataSource = currentLibrary;

            uxLibraryOwnerName.Text = u + "'s Library";
            setPlaylistViewInvisible();
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
            }


            uxPlaylistName.Text = "Playlist Name: "+currentPlaylist.PlaylistName;
            uxPlaylistOwnerName.Text = "Is owned by: "+currentPlaylist.PlaylistOwnerID.ToString();// Convert to PLAYLIST OWNER NAME!!!!!!!!

            uxSongslist.DataSource = currentPlaylistSongs;

            setPlaylistViewVisible();
        }

        private void uxAddSong_Click(object sender, EventArgs e)
        {
            /*SongAdd SAD = new SongAdd(allSongList);
            SAD.ShowDialog();
            if (SAD.DialogResult == DialogResult.OK)
            {
                //Whaddya do???
            }*/
        }

        private void uxStats_Click(object sender, EventArgs e)
        {

        }
    }
}