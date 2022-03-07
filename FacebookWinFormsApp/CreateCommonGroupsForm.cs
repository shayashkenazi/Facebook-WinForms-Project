using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;


namespace BasicFacebookFeatures
{
    public partial class CreateCommonGroupsForm : FormFeature
    {
        private readonly CreateCommonGroupsLogic r_SameFilterLogic;

        public CreateCommonGroupsForm()
        {
            InitializeComponent();
            r_SameFilterLogic = new CreateCommonGroupsLogic();
        }

        private bool isBindingSourceBind(BindingSource i_DataSource)
        {
            return i_DataSource.Count > 0;
        }

        private void buttonFilterBirthday_Click(object sender, EventArgs e)
        {
            if (buttonFilterBirthday.Enabled)
            {
                nameUser.Text = User.Name;
                pictureBoxUser.LoadAsync(User.PictureNormalURL);
                labelUserBirthday.Text = User.Birthday == null ? "No information about user birthday" : User.Birthday;
                listFriendBirthday_SelectedIndexChanged(sender, e);
                buttonFilterBirthday.Enabled = false;
            }
        }

        private void ButtonCheckSameLocation_Click(object sender, EventArgs e)
        {
            if (ButtonCheckSameLocation.Enabled)
            {
                nameUser.Text = User.Name;
                pictureBoxUser.LoadAsync(User.PictureNormalURL);
                labelUserLocation.Text = User.Location == null ? "No information about user Location" : User.Location.ToString();
                listFriendLocation_SelectedIndexChanged(sender, e);
                ButtonCheckSameLocation.Enabled = false;
            }
        }

        private void buttonPostGroupLocation_Click(object sender, EventArgs e)
        {
            r_SameFilterLogic.FilterGroup1.FilterGroupOfFriend.PostToWall(textBoxGroupLocation.Text);
            textBoxGroupLocation.Text = string.Empty;
        }

        private void buttonPostGroupBirthday_Click(object sender, EventArgs e)
        {
            r_SameFilterLogic.FilterGroup2.FilterGroupOfFriend.PostToWall(textBoxPostGroupBirthday.Text);
            textBoxPostGroupBirthday.Text = string.Empty;
        }

        private void listFriendLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_SameFilterLogic.FilterGroup1.CreateListAndGroup(User);
            listFriendLocation.Items.Clear();

            foreach (User user in r_SameFilterLogic.FilterGroup1.FilterListOfFriend)
            {
                listFriendLocation.Items.Add(user.Name);
            }

            if (listFriendLocation.Items.Count == 0)
            {
                MessageBox.Show("No friends with same Location:(");
                listFriendLocation.Items.Add("No friends with same Location");
            }
            else
            {
                buttonPostGroupLocation.Enabled = true;
            }

            listFriendLocation.Enabled = false;
        }

        private void listFriendBirthday_SelectedIndexChanged(object sender, EventArgs e)
        {
            listFriendBirthday.Items.Clear();
            r_SameFilterLogic.FilterGroup2.CreateListAndGroup(User);
            foreach (User user in r_SameFilterLogic.FilterGroup2.FilterListOfFriend)
            {
                listFriendBirthday.Items.Add(user.Name);
            }

            if (listFriendBirthday.Items.Count == 0)
            {
                MessageBox.Show("No friends with same Birthday:(");
                listFriendBirthday.Items.Add("No friends with same Birthday");
            }
            else
            {
                buttonPostGroupBirthday.Enabled = true;
            }

            listFriendBirthday.Enabled = false;
        }

        private void textBoxPostGroupBirthday_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBoxGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FetchPostFromGroup2_Click(object sender, EventArgs e)
        {
            new Thread(fetchGroupsLocation).Start();
        }

        private void fetchGroupsLocation()
        {
            try
            {
                if (r_SameFilterLogic.FilterGroup1.FilterGroupOfFriend.Members.Count != 0 && !isBindingSourceBind(postBindingSource))
                {
                    listBoxGroup2.Invoke(new Action(() => postBindingSource.DataSource = FacebookLogicManager.GetProxyPostsFromGroup(r_SameFilterLogic.FilterGroup1.FilterGroupOfFriend)));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to fetch posts from group - there is no group location.");
            }
        }

        private void FetchPostFromGroup1_Click(object sender, EventArgs e)
        {
            new Thread(fetchGroupsBirthday).Start();
        }

        private void fetchGroupsBirthday()
        {
            try
            {
                if (r_SameFilterLogic.FilterGroup2.FilterGroupOfFriend.Members.Count != 0 && !isBindingSourceBind(postBindingSource1))
                {
                    listBoxGroup1.Invoke(new Action(() => postBindingSource1.DataSource = FacebookLogicManager.GetProxyPostsFromGroup(r_SameFilterLogic.FilterGroup2.FilterGroupOfFriend)));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to fetch posts from group - there is no group birthday.");
            }
        }

        private void listBoxGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            if (buttonAddPhoto.Enabled)
            {
                openFileDialog1.ShowDialog();
                pictureBoxLocation.LoadAsync(openFileDialog1.FileName);
                pictureBoxLocation.Enabled = false;
            }
        }

        private void pictureBoxLocation_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
        }

        private void textBoxGroupLocation_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelUserLocation_Click(object sender, EventArgs e)
        {
        }

        private void labelUserBirthday_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}
