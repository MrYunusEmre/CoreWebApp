using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //add here your local database server name
            optionsBuilder.UseSqlServer("..;database=CoreBlogDb;integrated security = true");

        }
        public DbSet<About> Abouts { get; set; }

    }
}
