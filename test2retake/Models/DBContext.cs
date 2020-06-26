using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Models
{
    public class DBContext : DbContext
    {

        public DbSet<FireFighter> FireFighter { get; set; }
        public DbSet<Action> Action { get; set; }
        public DbSet<FireFighter_Action> FireFighter_Action { get; set; }      
        public DbSet<FireTruck> FireTruck { get; set; }
        public DbSet<FireTruck_Action> FireTruck_Action { get; set; }
        public DBContext()
        {

        }
        public DBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FireFighter_Action>().HasKey(e => new { e.IdFireFighter, e.IdAction });


        }
    }
}
