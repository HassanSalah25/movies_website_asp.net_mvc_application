using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies_website_asp.net_mvc_application.Models;

namespace movies_website_asp.net_mvc_application.Data
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies_Actors>().HasKey(ma => new { ma.ActorId, ma.MovieId });
            modelBuilder.Entity<Movies_Actors>().HasOne(m => m.Movies).WithMany(am => am.Movies_Actors).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Movies_Actors>().HasOne(m => m.Actors).WithMany(am => am.Movies_Actors).HasForeignKey(m => m.ActorId);

            modelBuilder.Entity<Users_Movies>().HasKey(um => new { um.UserId, um.MovieId });
            modelBuilder.Entity<Users_Movies>().HasOne(u => u.Movies).WithMany(um => um.Users_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Users_Movies>().HasOne(u => u.Users).WithMany(um => um.Users_Movies).HasForeignKey(m => m.UserId);

            base.OnModelCreating(modelBuilder);
        }

        public  DbSet<Actors> Actors { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Movies_Actors> Movies_Actors { get; set; }
        public DbSet<Users_Movies> Users_Movies { get; set; }
    }
}


