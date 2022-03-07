using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;


namespace BasicFacebookFeatures
{
    public class CreateCommonGroupsLogic
    {
        public IFilterGroupStrategy FilterGroup1 { get; set; }

        public IFilterGroupStrategy FilterGroup2 { get; set; }

        public CreateCommonGroupsLogic()
        {
            FilterGroup1 = new FilterByLocation();
            FilterGroup2 = new FilterByBirthday();
        }

        public class FilterByLocation : IFilterGroupStrategy
        {
            private Group m_GroupLocation = new Group();
            private List<User> m_ListOfFriendSameLocation = new List<User>();
            
            Group IFilterGroupStrategy.FilterGroupOfFriend
            {
                get
                {
                    return m_GroupLocation;
                }
                set
                {
                    m_GroupLocation = value;
                }
            }

            List<User> IFilterGroupStrategy.FilterListOfFriend
            {
                get
                {
                    return m_ListOfFriendSameLocation;
                }
                set
                {
                    m_ListOfFriendSameLocation = value;
                }
            }

            public void GroupOfFriend(bool i_isEmpty, User i_LoggedInUser)
            {
                try
                {
                    if(i_isEmpty == false)
                    {
                        i_LoggedInUser.Groups.Add(m_GroupLocation);
                        m_GroupLocation.Members.Clear();
                        foreach(User user in m_ListOfFriendSameLocation)
                        {
                            m_GroupLocation.Members.Add(user);
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Failed to create a group of user friends.");
                }
            }

            public void CreateListAndGroup(User i_LoggedInUser)
            {
                bool isEmpty = true;
                foreach(User user in i_LoggedInUser.Friends)
                {
                    if(user.Location != null && user.Location.Name.Equals(i_LoggedInUser.Location.Name))
                    {
                        m_ListOfFriendSameLocation.Add(user);
                        isEmpty = false;
                    }
                }

                GroupOfFriend(isEmpty, i_LoggedInUser);
            }
        }

        /// another strategy implementation
        public class FilterByBirthday : IFilterGroupStrategy
        {
            private Group m_GroupBirthday = new Group();
            private List<User> m_ListOfFriendSameBirthday = new List<User>();

            Group IFilterGroupStrategy.FilterGroupOfFriend
            {
                get
                {
                    return m_GroupBirthday;
                }
                set
                {
                    m_GroupBirthday = value;
                }
            }
            List<User> IFilterGroupStrategy.FilterListOfFriend
            {
                get
                {
                    return m_ListOfFriendSameBirthday;
                }
                set
                {
                    m_ListOfFriendSameBirthday = value;
                }

            }

            public void GroupOfFriend(bool i_isEmpty, User i_LoggedInUser)
            {
                try
                {
                    if(i_isEmpty == false)
                    {
                        i_LoggedInUser.Groups.Add(m_GroupBirthday);
                        m_GroupBirthday.Members.Clear();
                        foreach(User user in m_ListOfFriendSameBirthday)
                        {
                            m_GroupBirthday.Members.Add(user);
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Failed to create a group of user friends.");
                }
            }

            public void CreateListAndGroup(User i_LoggedInUser)
            {
                bool isEmpty = true;
                foreach(User user in i_LoggedInUser.Friends)
                {
                    if(user.Location != null && user.Location.Name.Equals(i_LoggedInUser.Location.Name))
                    {
                        m_ListOfFriendSameBirthday.Add(user);
                        isEmpty = false;
                    }
                }

                GroupOfFriend(isEmpty, i_LoggedInUser);
            }
        }

    }
}