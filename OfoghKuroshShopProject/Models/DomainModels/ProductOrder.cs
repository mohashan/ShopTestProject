using System.ComponentModel.DataAnnotations.Schema;

namespace OfoghKuroshShopProject.Models
{
	public class ProductOrder : BaseEntity
	{
		public int OrderId { get; set; }

		[ForeignKey("OrderId")]
		public Order Order { get; set; }

		public int ProductId { get; set; }

		[ForeignKey("ProductId")]
		public Product Product { get; set; }

		public int Amount { get; set; }
	}
}
