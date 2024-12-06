using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Database
{
    public class ViewModelSendContext : DbContext
    {
        public DbSet<ViewModelSend> viewmodelsend { get; set; }

        public ViewModelSendContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.config, new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
