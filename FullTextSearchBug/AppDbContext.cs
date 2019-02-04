using Microsoft.EntityFrameworkCore;

namespace FullTextSearchBug
{
	public class AppDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{ 
			optionsBuilder.UseNpgsql("Host=ec2-174-129-224-157.compute-1.amazonaws.com;Port=5432;sslmode=Require;Trust Server Certificate=true;Database=dbtqq3n6pv6r3u;Username=adpbgdpslbvxfn;Password=fe049ada7d4da32e8ba58d55e5743044a5db47d3fbedd1c0a63ebfa0f3af63fe");
			optionsBuilder.EnableSensitiveDataLogging();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppEntity>(typeBuilder => { typeBuilder.HasKey(z => z.Id); });
		}
	}
}