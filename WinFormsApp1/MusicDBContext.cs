using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    internal class MusicDBContext:DbContext
    {
        //Code for bringing the entity model that we created for User
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            // Code for getting the connection string from user secrets
            var builder = new ConfigurationBuilder().AddUserSecrets<MusicDBContext>();
            var configuration = builder.Build();
            var connectionString = configuration.GetConnectionString("Default");
            */

            //Code for connecting to SQL database
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
        }
    }
}
