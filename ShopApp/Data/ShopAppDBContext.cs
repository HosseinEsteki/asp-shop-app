
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopApp.Models;
using ShopApp.Models.Auth;
using ShopApp.Models.Design;

namespace ShopApp.Data
{
	public class ShopAppDBContext : DbContext
	{
		#region Config
		public ShopAppDBContext(DbContextOptions<ShopAppDBContext> options) : base(options)
		{
		}
		public ShopAppDBContext() : base()
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=ShopAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
			base.OnConfiguring(optionsBuilder);
		}
		#endregion
		public DbSet<Image> Images { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Property> Properties { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<UserAddress> UserAddresses { get; set; }
		public DbSet<ProductPropertyDetails> ProductPropertyDetails { get; set; }
		public DbSet<MenuItem> Menu { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            #region Relations
			
            #endregion
            #region AutoInclude
            modelBuilder.Entity<Category>().Navigation(e => e.Creator).AutoInclude();
			modelBuilder.Entity<Property>().Navigation(e => e.Creator).AutoInclude();
			modelBuilder.Entity<Product>().Navigation(e => e.Creator).AutoInclude();
			modelBuilder.Entity<Comment>().Navigation(e => e.Creator).AutoInclude();
			modelBuilder.Entity<Order>().Navigation(e => e.Customer).AutoInclude();
			modelBuilder.Entity<Tag>().Navigation(e => e.Creator).AutoInclude();
			modelBuilder.Entity<Category>().Navigation(e => e.Image).AutoInclude();
			modelBuilder.Entity<Product>().Navigation(e => e.Images).AutoInclude();
			modelBuilder.Entity<User>().Navigation(e => e.Image).AutoInclude();
			#endregion
			
			base.OnModelCreating(modelBuilder);
		}
	}
}
