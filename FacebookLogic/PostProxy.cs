using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class PostProxy
    {
        internal Post Post { get; set; }

        public static PostProxyCollection ProxyPosts { get; set; }

        public PostProxy(Post i_Post)
        {
            Post = i_Post;
        }

        internal static PostProxyCollection GetUserPostsAsProxyPosts(User i_User)
        {
            ProxyPosts = ConvertPostToPostProxyCollection(i_User.Posts);

            return ProxyPosts;
        }

        internal static PostProxyCollection ConvertPostToPostProxyCollection<T>(T i_Posts)
            where T : IEnumerable<Post>
        {
            return new PostProxyCollection(i_Posts);
        }
        public class PostProxyCollection : IEnumerable
        {
            private readonly List<Post> r_PostList;

            internal PostProxyCollection(IEnumerable<Post> i_PostList)
            {
                r_PostList = i_PostList.ToList();
            }

            public IEnumerator GetEnumerator()
            {
                foreach (Post post in r_PostList)
                {
                    yield return new PostProxy(post);
                }
            }

        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (Post.Message != null)
            {
                stringBuilder.Append(Post.Message);
            }
            else if (Post.PictureURL != null)
            {
                stringBuilder.Append("The Picture URL is: " + Post.PictureURL);
            }
            else
            {
                stringBuilder.Append("No Message. Created at time: " + Post.CreatedTime);
            }

            return stringBuilder.ToString();
        }
    }
}
