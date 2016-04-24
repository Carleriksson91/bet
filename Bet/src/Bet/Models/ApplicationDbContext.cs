using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Bet.Entities;

namespace Bet.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Group>().HasMany(x => x.Teams).WithOne().OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);

            builder.Entity<Team>().HasMany(x => x.Players).WithOne().OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);
            builder.Entity<Stadium>().HasMany(x => x.Games).WithOne().OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);

            //*Many to Many
            builder.Entity<TeamGame>().HasKey(x => new { x.TeamId, x.GameId });
            builder.Entity<TeamGame>()
            .HasOne(pt => pt.Game)
            .WithMany(p => p.TeamGames)
            .HasForeignKey(pt => pt.GameId);

            builder.Entity<TeamGame>()
            .HasOne(pt => pt.Team)
            .WithMany(p => p.TeamGames)
            .HasForeignKey(pt => pt.TeamId);

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
