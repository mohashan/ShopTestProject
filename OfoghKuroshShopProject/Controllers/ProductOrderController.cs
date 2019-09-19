using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfoghKuroshShopProject.Models;

namespace OfoghKuroshShopProject.Controllers
{
	[Authorize]
	public class ProductOrderController : BaseController
	{
		private readonly UserManager<User> userManager;
		private readonly SignInManager<User> signInManager;
		private readonly RoleManager<Role> roleManager;

		public ProductOrderController(UserManager<User> userManager,SignInManager<User> signInManager,RoleManager<Role> roleManager,ApplicationDbContext ctx):base(ctx)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.roleManager = roleManager;
		}
		public async Task<IActionResult> GetProductOfOrder(int Id)
		{
			var productOrders = ctx.ProductOrder.Where(c => c.OrderId == Id);
			if (!User.IsInRole("Admin"))
			{
				productOrders = productOrders.Where(c => c.Order.UserId == currentUserId);
			}
			return View("Index",await productOrders.Select(c => new Models.ViewModels.ProductOrderVM
			{
				Amount = c.Amount,
				ProductName = c.Product.Name,
			}).ToListAsync());
		}


	}
}
