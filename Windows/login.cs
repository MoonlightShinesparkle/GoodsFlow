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
using static GoodsFlow.Data.CommonVerif;
using GoodsFlow.Data.DataStore;
using GoodsFlow.UserManager;
using GoodsFlow.Data.DataStore.Tables;

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

        private async Task LoginBtnLogic()
        {
            string StoreName = GetStoreName();
            string GivenUserName = GetUserNameOrAdmin();
            string GivenPassword = PasswordIn.Text;

            if (!AreFilled(StoreName, GivenUserName, GivenPassword))
            {
                MessageBox.Show("All fields must be filled", "Invalid data");
                return;
            }

            StoreWrapper? FetchedStore = await SQLDSS.GetStoreData(StoreName);
            if (FetchedStore == null)
            {
                MessageBox.Show("Store not found", "Login failed");
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
            // Make sure the store wrapper is stored globally before killing the form, same for password .w."
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            await LoginBtnLogic();
        }

        private async Task CreateBtnLogic()
        {
            string StoreName = GetStoreName();
            string GivenUserName = GetUserNameOrAdmin();
            string Password = PasswordIn.Text;

            if (!AreFilled(StoreName, GivenUserName, Password))
            {
                MessageBox.Show("All fields must be filled to create a store", "Invalid data");
                return;
            }

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
            MessageBox.Show($"Trying to create {GivenUserName}'s store \"{StoreName}\" with password:{Environment.NewLine}\"{SaveablePassword.Entry}\"{Environment.NewLine}[Salt: {SaveablePassword.Salt}]");
#endif

            Store Created = new Store
            {
                Name = StoreName,
                AdminName = GivenUserName,
                AdminPass = SaveablePassword.Entry,
                AdminSalt = SaveablePassword.Salt
            };

            try
            {
                Supabase.Postgrest.Responses.ModeledResponse<Store> Result = await SQLDSS.SupabaseConnection.From<Store>().Insert(Created);

                MessageBox.Show("Data saved successfully","Store creation");

                Store Gotten = Result.Models.FirstOrDefault() ?? Created;

                StoreWrapper Loaded = await SQLDSS.LoadStoreDataAsync(Gotten);
            }
            catch (Exception E)
            {
                MessageBox.Show($"Could not create store:{Environment.NewLine}{E.Message}", "Store creation");
                return;
            }

            // TODO: User logged in, prepare and show dashboard somehow
            // Make sure the store wrapper is stored globally before killing the form, same for password .w."
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            await CreateBtnLogic();
        }
    }
}
