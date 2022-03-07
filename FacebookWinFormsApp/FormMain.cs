using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public sealed partial class FormMain : Form
    {
        private const string k_AppID = "569627957594255";
        private static readonly object sr_Lock = new object();
        private static FormMain s_FormMainInstance = null;
        private User m_LoggedInUser;
        private bool m_Visibility = true;
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;
        private FormExit m_FormExit = new FormExit();

        private FormMain()
        {
            InitializeComponent();
            m_AppSettings = AppSettings.LoadFromFile();
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            m_FormExit.m_ExitFormNotifier += exitApp;
            m_FormExit.m_RememberChangedNotifier += () => m_AppSettings.RememberUser = m_FormExit.RememberMe;
            m_FormExit.RememberMe = m_AppSettings.RememberUser;
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        public static FormMain FormMainInstance
        {
            get
            {
                if (s_FormMainInstance == null)
                {
                    lock (sr_Lock)
                    {
                        if (s_FormMainInstance == null)
                        {
                            s_FormMainInstance = new FormMain();
                        }
                    }
                }

                return s_FormMainInstance;
            }
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }

            set
            {
                if(value != null)
                {
                    this.m_LoginResult = value;
                    this.m_LoggedInUser = this.LoginResult.LoggedInUser;
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns22aa"); /// the current password for Desig Patter
            loginAndInit();
        }


        private void changeVisibilityOfAllControls(bool i_Visibility)
        {
            foreach (Control control in this.Controls)
            {
                changeVisibility(control, i_Visibility);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!m_FormExit.ToExit)
            {
                m_FormExit.ShowDialog();
                e.Cancel = true;
            }
        }
        
        private void changeVisibility(Control control, bool i_Visibility)
        {
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    changeVisibility(child, i_Visibility);
                }
            }

            control.Visible = i_Visibility;
        }
        private void clearDataSource(BindingSource i_DataSource)
        {
            i_DataSource.DataSource = null;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Text = "Facebook App";
            pictureBoxProfile.ImageLocation = null;
            pictureBoxSelectedPicture.ImageLocation = null;
            textBoxStatus.Text = string.Empty;
            clearDataSource(friendListBindingSource);
            clearDataSource(eventBindingSource);
            clearDataSource(photoBindingSource);
            clearDataSource(groupBindingSource1);
            clearDataSource(postBindingSource);
            changeVisibilityOfAllControls(!m_Visibility);
            FacebookLogicManager.LoggedInUser = null;
            FacebookService.LogoutWithUI();

            buttonLogin.Text = "Login";
            m_LoginResult = null;
        }
        private void exitApp()
        {
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;

            if (m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
            this.Close();
        }

        private bool loginAndInit()
        {
            bool hasLoggedInSuccessfully = false;
            LoginResult = FacebookService.Login(
                k_AppID,
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info");
            
            if(!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                FacebookLogicManager.LoggedInUser = m_LoggedInUser;
                changeVisibilityOfAllControls(true);
                this.fetchUserInfo();
                hasLoggedInSuccessfully = true;
            }
            else
            {
                MessageBox.Show("Login Failed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return hasLoggedInSuccessfully;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_AppSettings.RememberUser
                && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                new Thread(autoLogin).Start();
            }
        }

        private void autoLogin()
        {
            try
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                FacebookLogicManager.LoggedInUser = m_LoggedInUser;
                this.Invoke(new Action(() => this.Text = string.Format("Logged In As: {0}", m_LoggedInUser.Name)));
                this.Invoke(new Action(() => changeVisibilityOfAllControls(m_Visibility)));
                new Thread(fetchUserInfo).Start();
            }
            catch (Exception)
            {
                loginAndInit();
            }
        }
        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private bool isBindingSourceBind(BindingSource i_DataSource)
        {
            return i_DataSource.Count > 0;
        }

        private void fetchPosts()
        {
            if (!isBindingSourceBind(postBindingSource))
            {
                listBoxPosts.Invoke(new Action(() =>
                    postBindingSource.DataSource = FacebookLogicManager.GetProxyPosts()));
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("There Is No Posts In Feed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void listBoxPhotosInSelectedAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxPhotosInSelectedAlbum.SelectedItem is Photo selectedPhoto)
            {
                new Thread(displaySelectedPictureInAlbum).Start();
            }
        }

        private void displaySelectedPictureInAlbum()
        {
            listBoxPhotosInSelectedAlbum.Invoke(new Action(() =>
                {
                    Photo selectedPicture = listBoxPhotosInSelectedAlbum.SelectedItem as Photo;
                    if (selectedPicture.PictureNormalURL != null)
                    {
                        pictureBoxSelectedPicture.LoadAsync(selectedPicture.PictureThumbURL);
                    }
                    else
                    {
                        pictureBoxSelectedPicture.Image = pictureBoxSelectedPicture.ErrorImage;
                    }
                }));
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPageHomePage_Click(object sender, EventArgs e)
        {
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            new Thread(fetchGroups).Start();
        }

        private void fetchGroups()
        {
            if (!isBindingSourceBind(groupBindingSource1))
            {
                listBoxGroups.Invoke(new Action(() => groupBindingSource1.DataSource = m_LoggedInUser.Groups));
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("There Are No Groups", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Status Post Has Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                textBoxStatus.Text = "What's on your mind";
                this.buttonPost.Enabled = false;
                this.textBoxStatus.Enabled = false;
                textBoxStatus.ForeColor = SystemColors.ControlDark;
            }
        }

        private void fetchFriends()
        {
            if (!isBindingSourceBind(friendListBindingSource))
            {
                listBoxFriends.Invoke(new Action(() => friendListBindingSource.DataSource = m_LoggedInUser.Friends));
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("There Are No Friends", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        { 
            new Thread(fetchFriends).Start();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void fetchEvents()
        {
            if (!isBindingSourceBind(eventBindingSource))
            {
                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = m_LoggedInUser.Events));
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("There Are No Events", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxAlbums.SelectedItem is Album selectedAlbum)
            {
                new Thread(displaySelectedAlbum).Start();
            }
        }

        private void displaySelectedAlbum()
        {
            listBoxAlbums.Invoke(new Action(() =>
                {
                    Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                    listBoxPhotosInSelectedAlbum.Invoke(new Action(() => photoBindingSource.DataSource = selectedAlbum.Photos));
                    if (selectedAlbum.Photos.Count == 0)
                    {
                        MessageBox.Show("No Picture Albums To Retrieve...", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }));
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            if (!isBindingSourceBind(albumBindingSource))
            {
                listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = m_LoggedInUser.Albums));
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("There Is No Album", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void labelFeed_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxSelectedPicture_Click(object sender, EventArgs e)
        {
        }

        private void startFeature(eFeature i_Context)
        {
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("You need to login first.");

                return;
            }

            FormFeature feature = null;

            switch (i_Context)
            {
                case eFeature.TriviaFeature:
                    feature = FormFeatureFactory.Create(m_LoggedInUser, eFeature.TriviaFeature);
                    break;
                case eFeature.CreateCommonGroups:
                 feature = FormFeatureFactory.Create(m_LoggedInUser, eFeature.CreateCommonGroups);
                 break;
            }

            feature.Show();
        }
        
        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FetchTriviaForm_Click(object sender, EventArgs e)
        {
            startFeature(eFeature.TriviaFeature);
        }

        private void FetchCommonGroups_Click(object sender, EventArgs e)
        {
            startFeature(eFeature.CreateCommonGroups);
        }

    }
}
