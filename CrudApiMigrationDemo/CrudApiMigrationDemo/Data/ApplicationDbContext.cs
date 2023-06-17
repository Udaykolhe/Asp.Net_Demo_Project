using System.Data.Entity;

namespace CrudApiMigrationDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(): base("EmpMngSystemConn"){}

       // public DbSet<Student> Students {get; set;}
      //  public DbSet<User> Users { get; set; }
       // public DbSet<Test> Test4 { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Address> addrees { get; set; }
    }
}