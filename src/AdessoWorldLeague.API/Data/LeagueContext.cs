using AdessoWorldLeague.API.Configurations;
using AdessoWorldLeague.API.InData;

namespace AdessoWorldLeague.API.Data;

public class LeagueContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<TeamResult> TeamResults { get; set; }
    public DbSet<DrawResult> DrawResults { get; set; }
    
    public LeagueContext(DbContextOptions<LeagueContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DrawResultEntityTypeConfiguration());
        // modelBuilder.ApplyConfiguration(new TeamResultEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new TeamEntityTypeConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}