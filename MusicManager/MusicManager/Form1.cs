using MusicManagerUI;
using MusicManagerUI.Models;

namespace MusicManager
{
    public partial class Form1 : Form
    {
        UiUser SignedIn;
        UiUser LibOwner;
        List<UiUser> userList = new();
        List<UiPlaylist> currentLibrary = new();
        UiPlaylist currentPlaylist;
        List<UiSong> allSongList = new();
        public Form1()
        {
            InitializeComponent();
            setPlaylistViewInvisible();
            //Testing
            makeUsers();


            loginDialog();
            setLibrary(SignedIn);
            uxPlaylists.DataSource = currentLibrary;
            uxPlaylists.Columns["PlaylistID"].Visible = false;
            uxPlaylists.Columns["PlaylistOwnerID"].Visible = false;
            uxPlaylists.Columns["IsPrivate"].Visible = false;
            uxPlaylists.Columns["isDeleted"].Visible = false;
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
                SignedIn = LD.user;
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

        //-------------------------------------------------------------------------------------------------------------------------------

        public void makeUsers()//DELETE ME
        {
            userList.Add(new UiUser(1, "Hursen Adjovi", "hadjovi@ksu.edu", "adjovi"));
            userList.Add(new UiUser(2, "Ben Keller", "bkeller02@ksu.edu", "keller"));
            userList.Add(new UiUser(3, "Dennis Meyer", "dmeyer0282@ksu.edu", "meyer"));
            userList.Add(new UiUser(0, "Demo", "", ""));

            currentLibrary.Add(new UiPlaylist(1, "FirstPlaylist", 3, false, false));
            currentLibrary.Add(new UiPlaylist(2, "Second Playlist Priv", 3, true, false));
            currentLibrary.Add(new UiPlaylist(3, "third playlist pub", 3, false, false));
            currentLibrary.Add(new UiPlaylist(4, "fourth playlist Del", 3, false, true));
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
        private void setLibrary(UiUser u)
        {
            LibOwner = u;
            uxLibraryOwnerName.Text = u + "'s Library";
            //Set Library to selected user ----------------------------------------------------------------------------------------------
            //need to check somewhere for private playlists
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
                currentPlaylist = row.DataBoundItem as UiPlaylist;
            }

            uxPlaylistName.Text = currentPlaylist.PlaylistName;
            uxPlaylistOwnerName.Text = currentPlaylist.PlaylistOwnerID.ToString();// Convert to PLAYLIST OWNER NAME!!!!!!!!
            setPlaylistViewVisible();
        }

        private void uxAddSong_Click(object sender, EventArgs e)
        {
            SongAdd SAD = new SongAdd(allSongList);
            SAD.ShowDialog();
            if (SAD.DialogResult == DialogResult.OK)
            {
                //Whaddya do???
            }
        }

        private void uxStats_Click(object sender, EventArgs e)
        {

        }
    }
}