using Payments.Entities;
using Microsoft.EntityFrameworkCore;

namespace Payments.Data
{
  public class PaymentContext : DbContext
  {
    public string DbPath { get; }

    public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
    {
      var folder = Environment.SpecialFolder.LocalApplicationData;
      var path = Environment.GetFolderPath(folder);
      DbPath = System.IO.Path.Join(path, "Payments.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    public DbSet<Currency> CurrencyRepository { get; set; }
    public DbSet<Payment> PaymentRepository { get; set; }
    public DbSet<User> UserRepository { get; set; }

    // Override table names
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Currency>().ToTable("Courses");
      modelBuilder.Entity<Payment>().ToTable("Payments");
      modelBuilder.Entity<User>().ToTable("Students");
    }
  }
}