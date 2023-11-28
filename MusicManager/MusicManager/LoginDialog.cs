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
        List<User> users = new();
        public LoginDialog(List<User> users)
        {
            InitializeComponent();
            this.users = users;
            uxLoginBad.Visible = false;
        }

        public User user { get; private set; }
       
        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            foreach(User u in users){
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
