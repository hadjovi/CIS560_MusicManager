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
        public LoginDialog()
        {
            InitializeComponent();
            uxLoginBad.Visible = false;
        }

        public int UserKey=-1;//See how to track this
        public string UserName { get; private set; } = "";
        public String Email
        {
            get { return uxEmailBox.Text; }
        }
        public String Password
        {
            get { return uxPasswordBox.Text; }
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            
            //Check if login exists
            if (/*LoginExists*/true)//Login exists
            {
                //Set UserKey ?
                //SET USERNAME HERE
                UserName = uxEmailBox.Text;//CHANGE THIS

                DialogResult = DialogResult.OK;
            }
            else//Login does not exist
            {
                uxLoginBad.Visible = true;
            }


        }
    }
}
