using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogSite.Models
{
    public class BContext : DbContext
    {
        public DbSet<User> Blog { get; set; }
        public DbSet<Blog> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}