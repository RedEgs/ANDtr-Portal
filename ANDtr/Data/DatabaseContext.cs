using ANDtr.Models;
using Microsoft.EntityFrameworkCore;

namespace ANDtr.Data;

public class DatabaseContext : DbContext
{
    // The options (which database, connection string) are passed in from Program.cs
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    // Each DbSet becomes a table in the database
    public DbSet<Product> Products { get; set; }
}
