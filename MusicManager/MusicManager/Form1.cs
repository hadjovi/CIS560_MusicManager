using MusicManagerUI;

namespace MusicManager
{
    public partial class Form1 : Form
    {
        User SignedIn;
        User LibOwner;
        List<User> userList = new();
        public Form1()
        {
            InitializeComponent();
            setPlaylistViewInvisible();
            //Testing
            makeUsers();


            loginDialog();
            setLibrary(SignedIn);

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
            label4.Visible = false;
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
            label4.Visible = true;
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
            userList.Add(new User(1, "Hursen Adjovi", "hadjovi@ksu.edu", "adjovi"));
            userList.Add(new User(2, "Ben Keller", "bkeller02@ksu.edu", "keller"));
            userList.Add(new User(3, "Dennis Meyer", "dmeyer0282@ksu.edu", "meyer"));
            userList.Add(new User(0, "Demo", "", ""));
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
            uxLibraryOwnerName.Text = u + "'s Library";
            //Set Library to selected user ----------------------------------------------------------------------------------------------
            //need to check somewhere for private playlists
        }
        private void uxMyPlaylists_Click(object sender, EventArgs e)
        {
            setLibrary(SignedIn);
        }
    }
}