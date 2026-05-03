#define Debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GoodsFlow.Catppuccin.Components;
using static GoodsFlow.UserManager.LoginManager;
using GoodsFlow.Data.DataStore;
using GoodsFlow.UserManager;

namespace GoodsFlow.Windows
{
    public partial class login : CatppuccinForm
    {
        public login()
        {
            InitializeComponent();
        }

        public string GetStoreName() {
            return StoreIn.Text.ToLower();
        }

        public string GetUserNameOrAdmin()
        {
            string Given = UserIn.Text;
            if (Given.Trim() == "")
            {
                Given = "Admin";
            }
            return Given;
        }

        private void LoginFailureMessage()
        {
            MessageBox.Show("User or password are wrong, try again","Login failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string StoreName = GetStoreName();
            string GivenUserName = GetUserNameOrAdmin();
            string GivenPassword = PasswordIn.Text;

            Store? FetchedStore = SQLDSS.GetStoreData(StoreName);
            if (FetchedStore == null)
            {
                MessageBox.Show("Store not found","Login failed");
                return;
            }

            UserInfo? FetchedUser = FetchedStore.GetUser(GivenUserName);
            if (FetchedUser == null)
            {
                LoginFailureMessage();
                return;
            }

            if (!FetchedUser.PasswordMatches(GivenPassword))
            {
                LoginFailureMessage();
                return;
            }

#if Debug
            MessageBox.Show("Logged in :3c", "Success! OwO");
#endif

            // TODO: User logged in, prepare and show dashboard somehow
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string StoreName = GetStoreName();
            string Password = PasswordIn.Text;

            DialogResult Btn = MessageBox.Show("Store ID will be used as store name, it can be changed later in settings", "Store creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (Btn == DialogResult.Cancel)
            {
                MessageBox.Show("Operation aborted", "Store creation");
                return;
            }

            SaltedEntry SaveablePassword = Hash(Password);
            // Hashing it includes a salt accessable with SaveablePassword.Salt, the password itself is Entry and is encoded

            // Delete "#define Debug" to stop this from running
#if Debug
            MessageBox.Show($"Trying to create store \"{StoreName}\" with password:{Environment.NewLine}\"{SaveablePassword.Entry}\"{Environment.NewLine}[Salt: {SaveablePassword.Salt}]");
#endif
            // TODO: Create store
        }
    }
}
