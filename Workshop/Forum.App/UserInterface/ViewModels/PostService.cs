using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Forum.App.Services;

namespace Forum.App.UserInterface.ViewModels
{
    public static class PostService
    {
        internal static Category GetCategory(int categoryId)
        {
            ForumData forumData = new ForumData();

            Category category = forumData.Categories.Find(c => c.Id == categoryId);
            return category;
        }

        public static IEnumerable<Post> GetPostsByCategory(int categoryId)
        {
            ForumData forumData = new ForumData();
            var postIds = forumData.Categories.First(c => c.Id == categoryId).Posts;
            IEnumerable<Post> posts = forumData.Posts.Where(p => postIds.Contains(p.Id));
            return posts;

        }

        

        public static PostViewModel GetPostViewModel(int postId)
        {
            ForumData forumData = new ForumData();
            Post post = forumData.Posts.Find(p => p.Id == postId);
            PostViewModel pvm = new PostViewModel(post);
            return pvm;
        }

        internal static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            ForumData forumData = new ForumData();
            Post post = forumData.Posts.Find(p => p.Id == postId);
            IList<ReplyViewModel> replies = new List<ReplyViewModel>();

            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Find(r => r.Id == replyId);
                replies.Add(new ReplyViewModel(reply));
            }
            return replies;
        }

        internal static string[] GetAllCategoryNames()
        {
            ForumData forumData = new ForumData();
            var allCategories = forumData.Categories.Select(c => c.Name).ToArray();
            return allCategories;
        }

        private static Category EnsureCategory(PostViewModel postView, ForumData forumData)
        {
            var categoryName = postView.Category;
            Category category = forumData.Categories.FirstOrDefault(x => x.Name == categoryName);
            if (category == null)
            {
                var categories = forumData.Categories;
                int categoryId = categories.Any() ? categories.Last().Id + 1 : 1;
                category = new Category(categoryId,categoryName,new List<int>());
                forumData.Categories.Add(category);
            }
            return category;
        }

        public static bool TrySavePost(PostViewModel postView)
        {
            bool emptyCategory = string.IsNullOrWhiteSpace(postView.Category);
            bool emptyTitle = string.IsNullOrWhiteSpace(postView.Title);
            bool emptyContent = !postView.Content.Any();

            if (emptyContent || emptyCategory || emptyTitle)
            {
                return false;
            }

            ForumData forumData = new ForumData();
            Category category = EnsureCategory(postView, forumData);
            int postId = forumData.Posts.Any() ? forumData.Posts.Last().Id + 1 : 1;
            User author = UserService.GetUser(postView.Author);

            int authorId = author.Id;
            string content = string.Join("", postView.Content);

            Post post = new Post(postId,postView.Title,content,category.Id,authorId,new List<int>());
            forumData.Posts.Add(post);
            author.PostIds.Add(post.Id);
            category.Posts.Add(post.Id);
            forumData.SaveChanges();

            postView.PostId = postId;

            return true;
        }

        internal static bool TryAddReply(int postId, ReplyViewModel replyViewModel)
        {
            var forumData = new ForumData();

            var emptyReply = !replyViewModel.Content.Any();

            if (emptyReply) return false;

            var replyId = forumData.Replies.Any() ? forumData.Replies.Last().Id + 1 : 1;

            var content = string.Join("", replyViewModel.Content);

            var authorId = UserService.GetUser(replyViewModel.Author).Id;

            var reply = new Reply(replyId, content, authorId, postId);

            var post = forumData.Posts.FirstOrDefault(p => p.Id == postId);

            forumData.Replies.Add(reply);
            post.ReplyIds.Add(replyId);
            forumData.SaveChanges();

            return true;
        }
    }
}
