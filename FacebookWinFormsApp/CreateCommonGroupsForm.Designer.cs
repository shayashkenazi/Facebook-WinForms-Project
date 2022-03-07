namespace BasicFacebookFeatures
{
    public partial class CreateCommonGroupsForm
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
            this.listBoxGroup1 = new System.Windows.Forms.ListBox();
            this.postBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxGroup2 = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FetchPostFromGroup2 = new System.Windows.Forms.Button();
            this.FetchPostFromGroup1 = new System.Windows.Forms.Button();
            this.buttonPostGroupLocation = new System.Windows.Forms.Button();
            this.buttonPostGroupBirthday = new System.Windows.Forms.Button();
            this.textBoxGroupLocation = new System.Windows.Forms.TextBox();
            this.textBoxPostGroupBirthday = new System.Windows.Forms.TextBox();
            this.labelUserBirthday = new System.Windows.Forms.Label();
            this.labelUserLocation = new System.Windows.Forms.Label();
            this.listFriendBirthday = new System.Windows.Forms.ListBox();
            this.buttonFilterBirthday = new System.Windows.Forms.Button();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.pictureBoxLocation = new System.Windows.Forms.PictureBox();
            this.listFriendLocation = new System.Windows.Forms.ListBox();
            this.nameUser = new System.Windows.Forms.Label();
            this.ButtonCheckSameLocation = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGroup1
            // 
            this.listBoxGroup1.DataSource = this.postBindingSource1;
            this.listBoxGroup1.FormattingEnabled = true;
            this.listBoxGroup1.ItemHeight = 20;
            this.listBoxGroup1.Location = new System.Drawing.Point(477, 558);
            this.listBoxGroup1.Name = "listBoxGroup1";
            this.listBoxGroup1.Size = new System.Drawing.Size(217, 164);
            this.listBoxGroup1.TabIndex = 96;
            this.listBoxGroup1.SelectedIndexChanged += new System.EventHandler(this.listBoxGroup1_SelectedIndexChanged);
            // 
            // postBindingSource1
            // 
            this.postBindingSource1.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // listBoxGroup2
            // 
            this.listBoxGroup2.DataSource = this.postBindingSource;
            this.listBoxGroup2.FormattingEnabled = true;
            this.listBoxGroup2.ItemHeight = 20;
            this.listBoxGroup2.Location = new System.Drawing.Point(861, 558);
            this.listBoxGroup2.Name = "listBoxGroup2";
            this.listBoxGroup2.Size = new System.Drawing.Size(225, 164);
            this.listBoxGroup2.TabIndex = 95;
            this.listBoxGroup2.SelectedIndexChanged += new System.EventHandler(this.listBoxGroup2_SelectedIndexChanged);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // FetchPostFromGroup2
            // 
            this.FetchPostFromGroup2.Location = new System.Drawing.Point(1107, 593);
            this.FetchPostFromGroup2.Name = "FetchPostFromGroup2";
            this.FetchPostFromGroup2.Size = new System.Drawing.Size(121, 81);
            this.FetchPostFromGroup2.TabIndex = 94;
            this.FetchPostFromGroup2.Text = "Fetch post from group";
            this.FetchPostFromGroup2.UseVisualStyleBackColor = true;
            this.FetchPostFromGroup2.Click += new System.EventHandler(this.FetchPostFromGroup2_Click);
            // 
            // FetchPostFromGroup1
            // 
            this.FetchPostFromGroup1.Location = new System.Drawing.Point(334, 593);
            this.FetchPostFromGroup1.Name = "FetchPostFromGroup1";
            this.FetchPostFromGroup1.Size = new System.Drawing.Size(121, 81);
            this.FetchPostFromGroup1.TabIndex = 93;
            this.FetchPostFromGroup1.Text = "Fetch post from group";
            this.FetchPostFromGroup1.UseVisualStyleBackColor = true;
            this.FetchPostFromGroup1.Click += new System.EventHandler(this.FetchPostFromGroup1_Click);
            // 
            // buttonPostGroupLocation
            // 
            this.buttonPostGroupLocation.Enabled = false;
            this.buttonPostGroupLocation.Location = new System.Drawing.Point(795, 473);
            this.buttonPostGroupLocation.Name = "buttonPostGroupLocation";
            this.buttonPostGroupLocation.Size = new System.Drawing.Size(358, 57);
            this.buttonPostGroupLocation.TabIndex = 92;
            this.buttonPostGroupLocation.Text = "Post";
            this.buttonPostGroupLocation.UseVisualStyleBackColor = true;
            this.buttonPostGroupLocation.Click += new System.EventHandler(this.buttonPostGroupLocation_Click);
            // 
            // buttonPostGroupBirthday
            // 
            this.buttonPostGroupBirthday.Enabled = false;
            this.buttonPostGroupBirthday.Location = new System.Drawing.Point(399, 473);
            this.buttonPostGroupBirthday.Name = "buttonPostGroupBirthday";
            this.buttonPostGroupBirthday.Size = new System.Drawing.Size(352, 57);
            this.buttonPostGroupBirthday.TabIndex = 91;
            this.buttonPostGroupBirthday.Text = "Post";
            this.buttonPostGroupBirthday.UseVisualStyleBackColor = true;
            this.buttonPostGroupBirthday.Click += new System.EventHandler(this.buttonPostGroupBirthday_Click);
            // 
            // textBoxGroupLocation
            // 
            this.textBoxGroupLocation.Location = new System.Drawing.Point(795, 304);
            this.textBoxGroupLocation.Multiline = true;
            this.textBoxGroupLocation.Name = "textBoxGroupLocation";
            this.textBoxGroupLocation.Size = new System.Drawing.Size(358, 163);
            this.textBoxGroupLocation.TabIndex = 90;
            this.textBoxGroupLocation.Text = "Group location :What\'s on your mind";
            this.textBoxGroupLocation.TextChanged += new System.EventHandler(this.textBoxGroupLocation_TextChanged);
            // 
            // textBoxPostGroupBirthday
            // 
            this.textBoxPostGroupBirthday.Location = new System.Drawing.Point(393, 304);
            this.textBoxPostGroupBirthday.Multiline = true;
            this.textBoxPostGroupBirthday.Name = "textBoxPostGroupBirthday";
            this.textBoxPostGroupBirthday.Size = new System.Drawing.Size(358, 163);
            this.textBoxPostGroupBirthday.TabIndex = 89;
            this.textBoxPostGroupBirthday.Text = "Group birthday :What\'s on your mind";
            this.textBoxPostGroupBirthday.TextChanged += new System.EventHandler(this.textBoxPostGroupBirthday_TextChanged);
            // 
            // labelUserBirthday
            // 
            this.labelUserBirthday.AutoSize = true;
            this.labelUserBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserBirthday.Location = new System.Drawing.Point(472, 16);
            this.labelUserBirthday.Name = "labelUserBirthday";
            this.labelUserBirthday.Size = new System.Drawing.Size(210, 25);
            this.labelUserBirthday.TabIndex = 88;
            this.labelUserBirthday.Text = "The user birthday is:";
            this.labelUserBirthday.Click += new System.EventHandler(this.labelUserBirthday_Click);
            // 
            // labelUserLocation
            // 
            this.labelUserLocation.AutoSize = true;
            this.labelUserLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserLocation.Location = new System.Drawing.Point(878, 16);
            this.labelUserLocation.Name = "labelUserLocation";
            this.labelUserLocation.Size = new System.Drawing.Size(208, 25);
            this.labelUserLocation.TabIndex = 87;
            this.labelUserLocation.Text = "The user location is:";
            this.labelUserLocation.Click += new System.EventHandler(this.labelUserLocation_Click);
            // 
            // listFriendBirthday
            // 
            this.listFriendBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listFriendBirthday.FormattingEnabled = true;
            this.listFriendBirthday.ItemHeight = 26;
            this.listFriendBirthday.Location = new System.Drawing.Point(393, 132);
            this.listFriendBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listFriendBirthday.Name = "listFriendBirthday";
            this.listFriendBirthday.Size = new System.Drawing.Size(358, 134);
            this.listFriendBirthday.TabIndex = 86;
            this.listFriendBirthday.SelectedIndexChanged += new System.EventHandler(this.listFriendBirthday_SelectedIndexChanged);
            // 
            // buttonFilterBirthday
            // 
            this.buttonFilterBirthday.BackColor = System.Drawing.Color.Violet;
            this.buttonFilterBirthday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonFilterBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFilterBirthday.Location = new System.Drawing.Point(393, 45);
            this.buttonFilterBirthday.Name = "buttonFilterBirthday";
            this.buttonFilterBirthday.Size = new System.Drawing.Size(355, 80);
            this.buttonFilterBirthday.TabIndex = 85;
            this.buttonFilterBirthday.Text = "Click to create group of friends with same Birthday";
            this.buttonFilterBirthday.UseVisualStyleBackColor = false;
            this.buttonFilterBirthday.Click += new System.EventHandler(this.buttonFilterBirthday_Click);
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPhoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddPhoto.Location = new System.Drawing.Point(60, 272);
            this.buttonAddPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(223, 68);
            this.buttonAddPhoto.TabIndex = 84;
            this.buttonAddPhoto.Text = "Click to add a photo from The city";
            this.buttonAddPhoto.UseVisualStyleBackColor = false;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // pictureBoxLocation
            // 
            this.pictureBoxLocation.BackColor = System.Drawing.Color.White;
            this.pictureBoxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLocation.Location = new System.Drawing.Point(60, 362);
            this.pictureBoxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLocation.Name = "pictureBoxLocation";
            this.pictureBoxLocation.Size = new System.Drawing.Size(223, 195);
            this.pictureBoxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLocation.TabIndex = 83;
            this.pictureBoxLocation.TabStop = false;
            this.pictureBoxLocation.Click += new System.EventHandler(this.pictureBoxLocation_Click);
            // 
            // listFriendLocation
            // 
            this.listFriendLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listFriendLocation.FormattingEnabled = true;
            this.listFriendLocation.ItemHeight = 26;
            this.listFriendLocation.Location = new System.Drawing.Point(795, 132);
            this.listFriendLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listFriendLocation.Name = "listFriendLocation";
            this.listFriendLocation.Size = new System.Drawing.Size(358, 134);
            this.listFriendLocation.TabIndex = 82;
            this.listFriendLocation.SelectedIndexChanged += new System.EventHandler(this.listFriendLocation_SelectedIndexChanged);
            // 
            // nameUser
            // 
            this.nameUser.AutoSize = true;
            this.nameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameUser.Location = new System.Drawing.Point(102, 25);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(156, 32);
            this.nameUser.TabIndex = 80;
            this.nameUser.Text = "User Name";
            // 
            // ButtonCheckSameLocation
            // 
            this.ButtonCheckSameLocation.BackColor = System.Drawing.Color.Violet;
            this.ButtonCheckSameLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheckSameLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheckSameLocation.Location = new System.Drawing.Point(795, 45);
            this.ButtonCheckSameLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCheckSameLocation.Name = "ButtonCheckSameLocation";
            this.ButtonCheckSameLocation.Size = new System.Drawing.Size(358, 79);
            this.ButtonCheckSameLocation.TabIndex = 79;
            this.ButtonCheckSameLocation.Text = "Click to create group of friends with same Location";
            this.ButtonCheckSameLocation.UseVisualStyleBackColor = false;
            this.ButtonCheckSameLocation.Click += new System.EventHandler(this.ButtonCheckSameLocation_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(102, 60);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(156, 141);
            this.pictureBoxUser.TabIndex = 81;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CreateCommonGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 678);
            this.Controls.Add(this.listBoxGroup1);
            this.Controls.Add(this.listBoxGroup2);
            this.Controls.Add(this.FetchPostFromGroup2);
            this.Controls.Add(this.FetchPostFromGroup1);
            this.Controls.Add(this.buttonPostGroupLocation);
            this.Controls.Add(this.buttonPostGroupBirthday);
            this.Controls.Add(this.textBoxGroupLocation);
            this.Controls.Add(this.textBoxPostGroupBirthday);
            this.Controls.Add(this.labelUserBirthday);
            this.Controls.Add(this.labelUserLocation);
            this.Controls.Add(this.listFriendBirthday);
            this.Controls.Add(this.buttonFilterBirthday);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.pictureBoxLocation);
            this.Controls.Add(this.listFriendLocation);
            this.Controls.Add(this.nameUser);
            this.Controls.Add(this.ButtonCheckSameLocation);
            this.Controls.Add(this.pictureBoxUser);
            this.Name = "CreateCommonGroupsForm";
            this.Text = "CreateCommonGroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroup1;
        private System.Windows.Forms.ListBox listBoxGroup2;
        private System.Windows.Forms.Button FetchPostFromGroup2;
        private System.Windows.Forms.Button FetchPostFromGroup1;
        private System.Windows.Forms.Button buttonPostGroupLocation;
        private System.Windows.Forms.Button buttonPostGroupBirthday;
        private System.Windows.Forms.TextBox textBoxGroupLocation;
        private System.Windows.Forms.TextBox textBoxPostGroupBirthday;
        private System.Windows.Forms.Label labelUserBirthday;
        private System.Windows.Forms.Label labelUserLocation;
        private System.Windows.Forms.ListBox listFriendBirthday;
        private System.Windows.Forms.Button buttonFilterBirthday;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.PictureBox pictureBoxLocation;
        private System.Windows.Forms.ListBox listFriendLocation;
        private System.Windows.Forms.Label nameUser;
        private System.Windows.Forms.Button ButtonCheckSameLocation;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}