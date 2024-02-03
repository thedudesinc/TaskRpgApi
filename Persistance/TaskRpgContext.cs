using Microsoft.EntityFrameworkCore;
using TaskRpgApi.Persistance.Entities;

namespace TaskRpgApi.Persistance;

public partial class TaskRpgContext : DbContext
{
    public TaskRpgContext(DbContextOptions<TaskRpgContext> options)
        : base(options)
    { }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Quest> Quests { get; set; }

    public virtual DbSet<Character> Characters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasQueryFilter(entity => entity.DateDeleted == null).HasIndex(u => u.Email).IsUnique();
        modelBuilder.Entity<Quest>().HasQueryFilter(entity => entity.DateDeleted == null);
        modelBuilder.Entity<Character>().HasQueryFilter(entity => entity.DateDeleted == null);
    }
}
