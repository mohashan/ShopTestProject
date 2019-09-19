using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfoghKuroshShopProject.Models
{
	public class Product : BaseEntity
	{
		[StringLength(50,ErrorMessage = "طول فیلد نام کالا معتبر نیست")]
		public string Name { get; set; }

		[StringLength(50, ErrorMessage = "طول فیلد آدرس تصویر معتبر نیست")]
		public string ImageAddress { get; set; }

		public long Price { get; set; }

		public int State { get; set; }

		public virtual ICollection<ProductOrder> ProductOrders { get; set; }
	}
}
