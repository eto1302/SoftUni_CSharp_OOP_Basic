using System;
using System.Collections.Generic;
using System.Text;


public class ForumData
{
    public List<Category> Categories { get; set; }
    public List<User> Users { get; set; }
    public List<Post> Posts { get; set; }
    public List<Reply> Replies { get; set; }

    public ForumData()
    {
        this.Users = DataMapper.LoadUsers();
        this.Posts = DataMapper.LoadPosts();
        this.Replies = DataMapper.LoadReplies();
        this.Categories = DataMapper.LoadCategories();
    }

    public void SaveChanges()
    {
        DataMapper.SaveUsers(this.Users);
        DataMapper.SavePosts(this.Posts);
        DataMapper.SaveReplies(this.Replies);
        DataMapper.SaveCategories(this.Categories);
    }
}
