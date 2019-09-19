using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OfoghKuroshShopProject.Models
{
	public class ApplicationDbContext : IdentityDbContext<User, Role, int>
	//DbContext
	{
		/// <summary>
		/// In case of add sql server provider in startup class
		/// </summary>
		/// <param name="options">DbContextOptions</param>
		public ApplicationDbContext(DbContextOptions options)
			: base(options)
		{

		}

		public DbSet<Order> Order { get; set; }
		public DbSet<Product> Product { get; set; }
		public DbSet<ProductOrder> ProductOrder { get; set; }
		public DbSet<Basket> Basket { get; set; }
	}
}
