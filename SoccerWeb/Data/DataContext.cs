﻿using Microsoft.EntityFrameworkCore;
using SoccerBet.Web.Data.Entity;

namespace SoccerBet.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<GroupDetailEntity> GroupDetails { get; set; }

        public DbSet<GroupEntity> Groups { get; set; }

        public DbSet<MatchEntity> Matches { get; set; }

        public DbSet<TeamEntity> Teams { get; set; }

        public DbSet<TournamentEntity> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TeamEntity>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }

    }

}
