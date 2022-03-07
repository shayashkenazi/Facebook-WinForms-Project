using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public interface IFilterGroupStrategy
    {
        List<User> FilterListOfFriend { get; set; }
        Group FilterGroupOfFriend { get; set; }
        void GroupOfFriend(bool i_isEmpty, User i_LoggedInUser);
        void CreateListAndGroup(User i_LoggedInUser);
    }
}
