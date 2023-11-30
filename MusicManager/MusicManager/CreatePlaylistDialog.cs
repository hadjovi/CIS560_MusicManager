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
    public partial class CreatePlaylistDialog : Form
    {
        public CreatePlaylistDialog()
        {
            InitializeComponent();
            uxCreate.Enabled = false;
        }

        public String playName {  get; set; }
        public bool isPrivate {  get; set; }


        private void uxCreate_Click(object sender, EventArgs e)
        {
            playName = uxNameBox.Text;
            isPrivate = uxPrivate.Checked;
            DialogResult = DialogResult.OK;
        }

        private void uxNameBox_TextChanged(object sender, EventArgs e)
        {
            if (uxNameBox.Text.Trim().Equals(""))
            {
                uxCreate.Enabled = false;
            }
            else
            {
                uxCreate.Enabled = true;
            }
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        
    }
}
