using OAuthApi.Models;
using System.Data.Entity;

namespace OAuthApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("JWTAuthDBConn") { }


        public DbSet<Student> Students {get; set;}
        public DbSet<User> Users {get; set;}

    }
}