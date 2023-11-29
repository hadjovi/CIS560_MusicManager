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
    public partial class LoginDialog : Form
    {
        List<UiUser> users;
        public LoginDialog(List<UiUser> users)
        {
            InitializeComponent();
            this.users = users;
            uxLoginBad.Visible = false;
        }

        public UiUser user { get; private set; }
       
        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            foreach(UiUser u in users){
                if (u.LoginAttempt(uxEmailBox.Text,uxPasswordBox.Text))//Login exists
                {
                    user = u;
                    DialogResult = DialogResult.OK;
                }
            }
            uxLoginBad.Visible = true;
        }
    }
}
