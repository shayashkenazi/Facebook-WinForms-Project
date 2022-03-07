using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class FacebookLogicManager
    {
        public static User LoggedInUser { get; set; }

        public static PostProxy.PostProxyCollection GetProxyPosts()
        {
            return PostProxy.GetUserPostsAsProxyPosts(LoggedInUser);
        }

        public static PostProxy.PostProxyCollection GetProxyPostsFromGroup(Group i_Group)
        {
            PostProxy.ProxyPosts = PostProxy.ConvertPostToPostProxyCollection(i_Group.WallPosts);
            return PostProxy.ProxyPosts;
        }
    }
}