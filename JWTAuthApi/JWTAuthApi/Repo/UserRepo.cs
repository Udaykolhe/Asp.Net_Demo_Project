using OAuthApi.Data;
using OAuthApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuthApi.Repo
{
    public class UserRepo : IDisposable
    {
        AppDbContext context = new AppDbContext();

        public User validation(string username, string password)
        {
            return context.Users.FirstOrDefault(model => model.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && model.Password == password);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}