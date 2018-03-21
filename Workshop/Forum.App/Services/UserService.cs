using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Forum.App.Controllers;

namespace Forum.App.Services
{
    public static class UserService
    {
        public static bool TryLogInUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            ForumData forumData = new ForumData();
            bool userExists = forumData.Users.Any(u => u.Name == username && u.Password == password);

            return userExists;
        }

        internal static User GetUser(int userId)
        {
            ForumData forumData = new ForumData();

            User user = forumData.Users.Find(u => u.Id == userId);
            return user;
        }

        internal static User GetUser(string userName)
        {
            ForumData forumData = new ForumData();

            User user = forumData.Users.Find(u => u.Name == userName);
            return user;
        }

        public static SignUpController.SignUpStatus TrySignUpUser(string username, string password)
        {
            bool validUsername = !string.IsNullOrWhiteSpace(username) && username.Length > 3;
            bool validPassword = !string.IsNullOrWhiteSpace(password) && username.Length > 3;

            if (!validPassword || !validUsername)
            {
                return SignUpController.SignUpStatus.DetailsError;
            }

            ForumData forumData = new ForumData();

            bool userAlreadyExists = forumData.Users.Any(u => u.Name == username);

            if (!userAlreadyExists)
            {
                int userId = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;
                User user  = new User(userId, username, password);
                forumData.Users.Add(user);
                forumData.SaveChanges();

                return SignUpController.SignUpStatus.Success;
            }
            return SignUpController.SignUpStatus.UsernameTakenError;
        }
    }
}
