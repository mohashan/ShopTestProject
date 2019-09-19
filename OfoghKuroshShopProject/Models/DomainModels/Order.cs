using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfoghKuroshShopProject.Models
{
	public class Order : BaseEntity
	{
		public List<ProductOrder> ProductOrders { get; set; }

		public int UserId { get; set; }

		[ForeignKey("UserId")]
		public User User { get; set; }


	}
}
