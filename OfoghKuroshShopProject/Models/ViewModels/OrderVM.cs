using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfoghKuroshShopProject.Models.ViewModels
{
	public class OrderVM
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public int ProductOrdersCount { get; set; }
	}
}
