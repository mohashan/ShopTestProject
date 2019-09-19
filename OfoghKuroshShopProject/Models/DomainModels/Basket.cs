using System.ComponentModel.DataAnnotations.Schema;

namespace OfoghKuroshShopProject.Models
{
	public class Basket : BaseEntity
	{
		public int UserId { get; set; }

		[ForeignKey("UserId")]
		public User User { get; set; }

		public int ProductId { get; set; }

		[ForeignKey("ProductId")]
		public Product Product { get; set; }

		public int Amount { get; set; }
	}
}
