using LABOL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace LADAL
{
    public class LADbContext:IdentityDbContext<LAUser>
    {
        public LADbContext(DbContextOptions<LADbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.Migrate();
            //Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=ACE\SQLDEVELOPER2012;Database=LinkAbleDB;Trusted_Connection=True");
        //}

        public DbSet<Category> Categories { get; set; }
        //public DbSet<LAUser> LAUsers { get; set; }
        public DbSet<LAUrl> LAUrls { get; set; }
    }
}
