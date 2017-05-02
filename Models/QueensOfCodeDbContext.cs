using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QueensOfCodeProject.UI.Models
{
    public class QueensOfCodeDbContext : IdentityDbContext<AppUser>
    {
        public QueensOfCodeDbContext():base("QueensOfCode")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Page> Pages { get; set; }

       
    }
}