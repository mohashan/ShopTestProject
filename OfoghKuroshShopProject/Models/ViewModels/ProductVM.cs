using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfoghKuroshShopProject.Models.ViewModels
{
	public class ProductVM
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public long Price { get; set; }
		public string ImageAddress { get; set; }
	}
}
