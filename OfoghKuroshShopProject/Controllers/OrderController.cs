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
	public class OrderController : BaseController
	{
		public readonly IMapper mapper;
		private readonly UserManager<User> userManager;

		public OrderController(IMapper mapper, ApplicationDbContext ctx,UserManager<User> userManager):base(ctx)
		{
			this.mapper = mapper;
			this.userManager = userManager;
		}
		public async Task<IActionResult> Index()
		{
			var Orders = ctx.Order;
			List<OrderVM> model;
			if (User.IsInRole("Admin"))
				model = await mapper.ProjectTo<OrderVM>(Orders).ToListAsync();
			else
			{
				model = await mapper.ProjectTo<OrderVM>(ctx.Order.Where(c => c.UserId == currentUserId)).ToListAsync();
			}
			return View(model);
		}

		
	}
}
