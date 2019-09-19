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
	public class ProductController : BaseController
	{

		private readonly IMapper mapper;
		private readonly UserManager<User> userManager;

		public ProductController(ApplicationDbContext ctx,IMapper mapper,UserManager<User> userManager):base(ctx)
		{

			this.mapper = mapper;
			this.userManager = userManager;
		}
		public async Task<IActionResult> Index()
		{
			var products = await  mapper.ProjectTo<ProductVM>(ctx.Product).ToListAsync();
			return View(products);
		}

		public async Task<string> AddToBasket(int Id)
		{
			try
			{
				var product = await ctx.Product.FirstOrDefaultAsync(c => c.Id == Id);
				if(product == null)
				{
					return "کالا یافت نشد";
				}
				var prevBask = await ctx.Basket.FirstOrDefaultAsync(c => c.ProductId == Id && c.UserId == currentUserId);
				if (prevBask == null)
				{
					var res = ctx.Basket.Add(new Basket
					{
						Amount = 1,
						InsertDate = DateTime.Now,
						ProductId = product.Id,
						UserId = currentUserId
					});
				}
				else
				{
					prevBask.Amount += 1;
					ctx.Entry<Basket>(prevBask).State = EntityState.Modified;
				}

				await ctx.SaveChangesAsync();
				return "ثبت موفق";
			}
			catch (Exception ex)
			{
				return "خطا در ثبت";
			}
			
		}

		
	}
}
