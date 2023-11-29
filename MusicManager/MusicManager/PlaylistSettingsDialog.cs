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
    public partial class PlaylistSettingsDialog : Form
    {
        UiPlaylist P;
        public PlaylistSettingsDialog(UiPlaylist Play)
        {
            InitializeComponent();
            P = Play;
            uxPlaylistName.Text = P.PlaylistName;
            uxIsPrivate.Checked = P.IsPrivate;
        }

        private void uxUpdateSettings_Click(object sender, EventArgs e)
        {
            if (!P.PlaylistName.Equals(uxPlaylistName.Text))
            {
                //Update Name
            }
            if (!P.IsPrivate == uxIsPrivate.Checked)
            {
                //Update Privacy
            }
            if(!P.IsDeleted == uxDeletePlaylist.Checked)
            {
                //Update Deleted
            }
            DialogResult = DialogResult.OK;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
