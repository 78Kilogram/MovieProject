using MovieProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data
{
    public class MovieProjectDbContext : DbContext
    {
        public MovieProjectDbContext():base("MovieProjectConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Ads> Ads { set; get; }
        public DbSet<Category> Category { set; get; }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Movie> Movies { set; get; }
        public DbSet<New> News { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Trailer> Trailer { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }



    }
}
