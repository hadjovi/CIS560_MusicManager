using MusicManagerUI;

namespace MusicManager
{
    public partial class Form1 : Form
    {
        String username;
        public Form1()
        {
            InitializeComponent();
            setPlaylistViewInvisible();
            username = loginDialog();
        }



        /// <summary>
        /// HAVE THIS RETURN USER KEY OR WHATEVER IS NEEDED TO ID THE USER
        /// </summary>
        /// <returns></returns>
        public String loginDialog()
        {
            string Username="";
            LoginDialog LD = new LoginDialog();
            LD.ShowDialog();
            if (LD.DialogResult == DialogResult.OK)
            {
                username = LD.UserName;
                Text = "Music Manager - " + username;
            }
            else
            {
                MessageBox.Show("Error in Login Dialog", "Error");
            }
            return Username;

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

            uxNoPlaylistWarning.Visible = false;
        }
    }
}