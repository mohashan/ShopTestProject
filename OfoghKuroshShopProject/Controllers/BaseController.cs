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

namespace OfoghKuroshShopProject.Controllers
{
	public partial class BaseController : Controller
	{
		public readonly ApplicationDbContext ctx;
		public int currentUserId
		{
			get
			{
				return CurrentUserId();
			}
		}
		public BaseController(ApplicationDbContext ctx)
		{
			this.ctx = ctx;
		}
		private int CurrentUserId()
		{
			return (ctx.Users.FirstOrDefaultAsync(c => c.UserName == HttpContext.User.Identity.Name).Result).Id;
		}

	}
}
