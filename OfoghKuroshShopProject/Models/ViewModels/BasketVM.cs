using System.ComponentModel.DataAnnotations.Schema;

namespace OfoghKuroshShopProject.Models.ViewModels
{
	public class BasketVM
	{
		public int Id { get; set; }

		public string ProductName { get; set; }

		public int Amount { get; set; }
	}
}
