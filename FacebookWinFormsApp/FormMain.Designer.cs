namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageHomePage = new System.Windows.Forms.TabPage();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.FetchCommonGroups = new System.Windows.Forms.Button();
            this.FetchTriviaForm = new System.Windows.Forms.Button();
            this.labelFeed = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.pictureBoxSelectedPicture = new System.Windows.Forms.PictureBox();
            this.listBoxPhotosInSelectedAlbum = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelNewStatus = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).BeginInit();
            this.tabPageHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPicture)).BeginInit();
            this.Tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // groupBindingSource1
            // 
            this.groupBindingSource1.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // postBindingSource2
            // 
            this.postBindingSource2.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // postBindingSource1
            // 
            this.postBindingSource1.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // albumBindingSource1
            // 
            this.albumBindingSource1.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // tabPageHomePage
            // 
            this.tabPageHomePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageHomePage.BackgroundImage")));
            this.tabPageHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageHomePage.Controls.Add(this.listBoxEvents);
            this.tabPageHomePage.Controls.Add(this.FetchCommonGroups);
            this.tabPageHomePage.Controls.Add(this.FetchTriviaForm);
            this.tabPageHomePage.Controls.Add(this.labelFeed);
            this.tabPageHomePage.Controls.Add(this.pictureBoxProfile);
            this.tabPageHomePage.Controls.Add(this.buttonFetchFriends);
            this.tabPageHomePage.Controls.Add(this.buttonFetchEvents);
            this.tabPageHomePage.Controls.Add(this.buttonFetchGroups);
            this.tabPageHomePage.Controls.Add(this.buttonFetchAlbums);
            this.tabPageHomePage.Controls.Add(this.pictureBoxSelectedPicture);
            this.tabPageHomePage.Controls.Add(this.listBoxPhotosInSelectedAlbum);
            this.tabPageHomePage.Controls.Add(this.listBoxAlbums);
            this.tabPageHomePage.Controls.Add(this.listBoxGroups);
            this.tabPageHomePage.Controls.Add(this.listBoxFriends);
            this.tabPageHomePage.Controls.Add(this.listBoxPosts);
            this.tabPageHomePage.Controls.Add(this.buttonFetchPosts);
            this.tabPageHomePage.Controls.Add(this.buttonPost);
            this.tabPageHomePage.Controls.Add(this.textBoxStatus);
            this.tabPageHomePage.Controls.Add(this.labelNewStatus);
            this.tabPageHomePage.Controls.Add(this.buttonLogout);
            this.tabPageHomePage.Controls.Add(this.buttonLogin);
            this.tabPageHomePage.Location = new System.Drawing.Point(4, 29);
            this.tabPageHomePage.Name = "tabPageHomePage";
            this.tabPageHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHomePage.Size = new System.Drawing.Size(1253, 1081);
            this.tabPageHomePage.TabIndex = 0;
            this.tabPageHomePage.Text = "HomePage";
            this.tabPageHomePage.UseVisualStyleBackColor = true;
            this.tabPageHomePage.Click += new System.EventHandler(this.tabPageHomePage_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(304, 479);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(201, 184);
            this.listBoxEvents.TabIndex = 76;
            this.listBoxEvents.Visible = false;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // FetchCommonGroups
            // 
            this.FetchCommonGroups.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FetchCommonGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FetchCommonGroups.Location = new System.Drawing.Point(876, 27);
            this.FetchCommonGroups.Name = "FetchCommonGroups";
            this.FetchCommonGroups.Size = new System.Drawing.Size(257, 56);
            this.FetchCommonGroups.TabIndex = 88;
            this.FetchCommonGroups.Text = "Fetch Common Groups";
            this.FetchCommonGroups.UseVisualStyleBackColor = false;
            this.FetchCommonGroups.Click += new System.EventHandler(this.FetchCommonGroups_Click);
            // 
            // FetchTriviaForm
            // 
            this.FetchTriviaForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FetchTriviaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FetchTriviaForm.Location = new System.Drawing.Point(620, 27);
            this.FetchTriviaForm.Name = "FetchTriviaForm";
            this.FetchTriviaForm.Size = new System.Drawing.Size(220, 56);
            this.FetchTriviaForm.TabIndex = 87;
            this.FetchTriviaForm.Text = "Fetch Trivia Feature";
            this.FetchTriviaForm.UseVisualStyleBackColor = false;
            this.FetchTriviaForm.Click += new System.EventHandler(this.FetchTriviaForm_Click);
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFeed.Location = new System.Drawing.Point(406, 191);
            this.labelFeed.Name = "labelFeed";
            this.labelFeed.Size = new System.Drawing.Size(93, 37);
            this.labelFeed.TabIndex = 86;
            this.labelFeed.Text = "Feed";
            this.labelFeed.Visible = false;
            this.labelFeed.Click += new System.EventHandler(this.labelFeed_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(6, 150);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(277, 256);
            this.pictureBoxProfile.TabIndex = 85;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(104, 414);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(157, 46);
            this.buttonFetchFriends.TabIndex = 83;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Visible = false;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(344, 422);
            this.buttonFetchEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(136, 43);
            this.buttonFetchEvents.TabIndex = 84;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Visible = false;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(547, 426);
            this.buttonFetchGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(149, 35);
            this.buttonFetchGroups.TabIndex = 82;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Visible = false;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(772, 420);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(160, 41);
            this.buttonFetchAlbums.TabIndex = 81;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Visible = false;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // pictureBoxSelectedPicture
            // 
            this.pictureBoxSelectedPicture.Location = new System.Drawing.Point(990, 538);
            this.pictureBoxSelectedPicture.Name = "pictureBoxSelectedPicture";
            this.pictureBoxSelectedPicture.Size = new System.Drawing.Size(186, 150);
            this.pictureBoxSelectedPicture.TabIndex = 80;
            this.pictureBoxSelectedPicture.TabStop = false;
            this.pictureBoxSelectedPicture.Visible = false;
            this.pictureBoxSelectedPicture.Click += new System.EventHandler(this.pictureBoxSelectedPicture_Click);
            // 
            // listBoxPhotosInSelectedAlbum
            // 
            this.listBoxPhotosInSelectedAlbum.DataSource = this.photoBindingSource;
            this.listBoxPhotosInSelectedAlbum.FormattingEnabled = true;
            this.listBoxPhotosInSelectedAlbum.ItemHeight = 20;
            this.listBoxPhotosInSelectedAlbum.Location = new System.Drawing.Point(974, 399);
            this.listBoxPhotosInSelectedAlbum.Name = "listBoxPhotosInSelectedAlbum";
            this.listBoxPhotosInSelectedAlbum.Size = new System.Drawing.Size(223, 124);
            this.listBoxPhotosInSelectedAlbum.TabIndex = 79;
            this.listBoxPhotosInSelectedAlbum.Visible = false;
            this.listBoxPhotosInSelectedAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosInSelectedAlbum_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(752, 479);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(199, 184);
            this.listBoxAlbums.TabIndex = 78;
            this.listBoxAlbums.Visible = false;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DataSource = this.groupBindingSource1;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(544, 479);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(152, 184);
            this.listBoxGroups.TabIndex = 77;
            this.listBoxGroups.Visible = false;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.friendListBindingSource;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(62, 467);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(210, 184);
            this.listBoxFriends.TabIndex = 75;
            this.listBoxFriends.Visible = false;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(379, 240);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(717, 144);
            this.listBoxPosts.TabIndex = 74;
            this.listBoxPosts.Visible = false;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(1112, 267);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(97, 65);
            this.buttonFetchPosts.TabIndex = 73;
            this.buttonFetchPosts.Text = "Fetch Post";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Visible = false;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1112, 109);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(92, 70);
            this.buttonPost.TabIndex = 72;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Visible = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(379, 103);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(717, 76);
            this.textBoxStatus.TabIndex = 71;
            this.textBoxStatus.Text = "What\'s on your mind";
            this.textBoxStatus.Visible = false;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // labelNewStatus
            // 
            this.labelNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewStatus.Location = new System.Drawing.Point(384, 48);
            this.labelNewStatus.Name = "labelNewStatus";
            this.labelNewStatus.Size = new System.Drawing.Size(230, 52);
            this.labelNewStatus.TabIndex = 70;
            this.labelNewStatus.Text = "new status";
            this.labelNewStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNewStatus.Visible = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(4, 93);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 35);
            this.buttonLogout.TabIndex = 69;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(4, 48);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 35);
            this.buttonLogin.TabIndex = 68;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPageHomePage);
            this.Tabs.Location = new System.Drawing.Point(2, -5);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1261, 1114);
            this.Tabs.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 724);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook aplication";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).EndInit();
            this.tabPageHomePage.ResumeLayout(false);
            this.tabPageHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPicture)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource albumBindingSource1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource friendListBindingSource;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource1;
        private System.Windows.Forms.BindingSource postBindingSource2;
        private System.Windows.Forms.TabPage tabPageHomePage;
        private System.Windows.Forms.Button FetchCommonGroups;
        private System.Windows.Forms.Button FetchTriviaForm;
        private System.Windows.Forms.Label labelFeed;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.PictureBox pictureBoxSelectedPicture;
        private System.Windows.Forms.ListBox listBoxPhotosInSelectedAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelNewStatus;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabControl Tabs;
    }
}
