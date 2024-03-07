﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class UehEventContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Sight> Sights { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<PlayHis> PlayHises { get; set; }
    public DbSet<SightHis> SightHises { get; set; }
    public DbSet<TPointHis> TPointHises { get; set; }

    private string connectionString = Constants.connectionString;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            // .UseLoggerFactory(loggerFactory)
            // .UseLazyLoadingProxies()
            .UseSqlServer(connectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>()
            .HasMany(q => q.Answers)
            .WithOne()
            .HasForeignKey("QuestionId")
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Account>()
            .HasOne(a => a.Student)
            .WithOne()
            .HasForeignKey<Account>(a => a.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SightHis>()
            .HasOne(s => s.Student)
            .WithMany()
            .HasForeignKey(s => s.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SightHis>()
            .HasOne(s => s.Sight)
            .WithMany()
            .HasForeignKey(s => s.SightId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PlayHis>()
            .HasOne(s => s.Student)
            .WithMany()
            .HasForeignKey(s => s.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PlayHis>()
            .HasOne(s => s.Game)
            .WithMany()
            .HasForeignKey(s => s.GameId)
            .OnDelete(DeleteBehavior.Cascade);

        // Your other configurations...

        base.OnModelCreating(modelBuilder);
    }
}