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

        public LoginDialog(List<User> users)
        {
            InitializeComponent();
            uxLoginBad.Visible = false;
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
    }
}
