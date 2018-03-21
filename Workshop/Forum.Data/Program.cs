using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var forumData = new ForumData();

            forumData.Users.Add(new User(1, "firstUser", "firstPassword", new List<int>{1, 2, 3, 4}));
            forumData.Categories.Add(new Category(1, "firstUser", new List<int>{1, 2, 3, 4}));
            forumData.Posts.Add(new Post(1, "post1", "post1 content", 1, 2, new List<int>{1, 2, 3, 4, 5}));
            forumData.Replies.Add(new Reply(1, "reply1 content", 2, 3));
            forumData.SaveChanges();
        }
    }
}
