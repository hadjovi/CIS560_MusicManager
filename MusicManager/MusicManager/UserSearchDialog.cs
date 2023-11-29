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
    public partial class UserSearchDialog : Form
    {
        List<UiUser> allUsers;
        List<UiUser> searchedUsers;
        public UiUser user;
        public UserSearchDialog(List<UiUser> u)
        {
            InitializeComponent();
            allUsers = u;
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            searchedUsers = new();
            foreach(UiUser u in allUsers)
            {
                if (u.Name.ToLower().Contains(uxNameSearchBox.Text))
                {
                    searchedUsers.Add(u);
                }
            }
            uxUserListBox.DataSource = searchedUsers;
            if(searchedUsers.Count == 0)
            {
                uxSelect.Enabled = false;
            }
            else
            {
                uxSelect.Enabled = true;
            }
        }

        private void uxSelect_Click(object sender, EventArgs e)
        {
            user = (UiUser)uxUserListBox.SelectedItem;
            DialogResult = DialogResult.OK;
        }
    }
}
