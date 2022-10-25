using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcUniversity.Models;

namespace MvcUniversity.Data;

public class MvcUniversityContext : DbContext
{
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Enrollement> Enrollements { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    

    public string DbPath { get; private set; }

    public MvcUniversityContext()
    {
        // Path to SQLite database file
        DbPath = "EFUniversity.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}