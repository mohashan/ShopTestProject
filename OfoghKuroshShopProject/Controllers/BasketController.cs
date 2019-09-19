using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfoghKuroshShopProject.Models;
using OfoghKuroshShopProject.Models.ViewModels;

namespace OfoghKuroshShopProject.Controllers
{
	[Authorize]
	public class BasketController : BaseController
	{

		private readonly IMapper mapper;
		private readonly UserManager<User> userManager;

		public BasketController(ApplicationDbContext ctx,IMapper mapper,UserManager<User> userManager):base(ctx)
		{

			this.mapper = mapper;
			this.userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			//var user = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);
			var basketItems = await  mapper.ProjectTo<BasketVM>(ctx.Basket.Where(c=>c.UserId == currentUserId)).ToListAsync();
			return View(basketItems);
		}

		public async Task<IActionResult> RegisterBasket()
		{
			ctx.Database.BeginTransaction();
			try
			{
				//var user = await ctx.Users.FirstOrDefaultAsync(c=>c.UserName == CurrentUser);
				var basketItems = await ctx.Basket.Where(c => c.UserId == currentUserId).ToListAsync();
				var order = new Order
				{
					InsertDate = DateTime.Now,
					UserId = currentUserId
				};
				
				ctx.Order.Add(order);


				ctx.ProductOrder.AddRange(basketItems.Select(c => new ProductOrder {
					Amount = c.Amount,
					InsertDate = DateTime.Now,
					OrderId = order.Id,
					ProductId = c.ProductId
				}));

				ctx.Basket.RemoveRange(basketItems);

				await ctx.SaveChangesAsync();
				ctx.Database.CommitTransaction();
				return RedirectToAction("Index", "Order");
			}
			catch (Exception ex)
			{
				ctx.Database.RollbackTransaction();
				return RedirectToAction("Index");
			}
			
		}

		[HttpPost]
		public async Task<IActionResult> Delete(int Id)
		{
			var basket = await ctx.Basket.FirstOrDefaultAsync(c => c.Id == Id && c.UserId == currentUserId);
			ctx.Basket.Remove(basket);
			await ctx.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		public async Task<int> GetBasketSummary()
		{
			return await ctx.Basket.Where(c => c.UserId == currentUserId).SumAsync(c=>c.Amount);
		}


	}
}
