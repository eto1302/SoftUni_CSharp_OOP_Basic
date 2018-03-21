using System.Collections.Generic;
using System.Linq;
using Forum.App.Services;
using Forum.App.UserInterface.Input;
using Forum.App.UserInterface.ViewModels;
using Forum.App.Views;

namespace Forum.App.Controllers
{
    using Forum.App.Controllers.Contracts;
    using Forum.App.UserInterface.Contracts;

    public class AddReplyController : IController
    {
        private const int TEXT_AREA_WIDTH = 37;
        private const int TEXT_AREA_HEIGHT = 6;
        private const int POST_MAX_LENGTH = 220;

        private static int centerTop = Position.ConsoleCenter().Top;
        private static int centerLeft = Position.ConsoleCenter().Left;

        public int PostId { get; private set; }
        private PostViewModel post { get; set; }
        private ReplyViewModel reply { get; set; }
        public  bool Error { get; private set; }
        private TextArea textArea { get; set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Write:
                    textArea.Write();
                    reply.Content = this.textArea.Lines.ToList();
                    return MenuState.AddReply;
                case Command.Submit:
                    var validReply = PostService.TryAddReply(this.post.PostId, this.reply);
                    if (!validReply)
                    {
                        Error = true;
                        return MenuState.Rerender;
                    }
                    return MenuState.ReplyAdded;
                case Command.Back:
                    return MenuState.Back;
            }

            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            return new AddReplyView(post,reply,textArea,Error);
        }

        public void SetReplyToPost(int postId, string username)
        {
            PostId = postId;
            post = PostService.GetPostViewModel(postId);

            ResetReply();
            reply.Author = username;
        }

        public void ResetReply()
        {
            this.Error = false;
            this.reply = new ReplyViewModel();
            this.textArea = new TextArea(centerLeft - 18, centerTop - 7, TEXT_AREA_WIDTH, TEXT_AREA_HEIGHT, POST_MAX_LENGTH);
        }

        private enum Command
        {
            Write,Submit,Back
        }
    }
}
