using System;
using System.Collections.Generic;
using System.Text;
namespace Common.Database
{
    public class UserContext : DbContext
    {
        public DbSet<User> user { get; set; }

        public UserContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.config, new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
