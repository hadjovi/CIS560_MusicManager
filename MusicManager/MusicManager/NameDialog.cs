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
    public partial class NameDialog : Form
    {
        public NameDialog()
        {
            InitializeComponent();
        }

        public string nam { get; set; }
        private void uxCreate_Click(object sender, EventArgs e)
        {
            if (!uxName.Text.Equals(""))
            {
                nam = uxName.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
