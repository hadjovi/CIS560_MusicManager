using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicData;
using MusicData.Models;

namespace MusicManagerUI
{
    public partial class LoginDialog : Form
    {
        
        SqlUserRepository repo = new SqlUserRepository(@"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;");
        List<User> allU = new();

        public LoginDialog(List<User> users)
        {
            InitializeComponent();
            uxLoginBad.Visible = false;
            allU = users;
        }

        public User user { get; private set; }
       
        private void uxLoginButton_Click(object sender, EventArgs e)
        {

            if (repo.GetUser(uxEmailBox.Text, uxPasswordBox.Text) != null)
            {
                user = repo.GetUser(uxEmailBox.Text, uxPasswordBox.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                uxLoginBad.Visible = true;

            }
        }

        private void uxCreate_Click(object sender, EventArgs e)
        {
            bool emailExists = false;
            foreach(User u in allU)
            {
                if (u.Email.ToLower().Equals(uxEmailBox.Text.ToLower())) emailExists = true;
            }
            if (emailExists)
            {
                MessageBox.Show("User exists with email");
            }
            else
            {
                NameDialog ND = new NameDialog();
                ND.ShowDialog();
                if (ND.DialogResult == DialogResult.OK)
                {
                    repo.CreateUser(ND.nam, uxEmailBox.Text, uxPasswordBox.Text);
                }

            }
        }
    }
}
