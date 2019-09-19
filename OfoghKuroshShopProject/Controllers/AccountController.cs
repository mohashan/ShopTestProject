using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OfoghKuroshShopProject.Models;

namespace OfoghKuroshShopProject.Controllers
{
	public class AccountController : BaseController
	{
		private readonly UserManager<User> userManager;
		private readonly SignInManager<User> signInManager;
		private readonly RoleManager<Role> roleManager;

		public AccountController(UserManager<User> userManager,SignInManager<User> signInManager,RoleManager<Role> roleManager,ApplicationDbContext ctx):base(ctx)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.roleManager = roleManager;

		}
		[AllowAnonymous]
		public async Task Index()
		{
			if (!(await roleManager.RoleExistsAsync("Admin")))
			{
				await roleManager.CreateAsync(new Role { Name = "Admin" });
			}

			if (!(await roleManager.RoleExistsAsync("Client")))
			{
				await roleManager.CreateAsync(new Role { Name = "Client" });
			}

			if ((await userManager.FindByNameAsync("MohaShan")) == null)
			{
				var res1 = await userManager.CreateAsync(new Models.User
				{
					UserName = "MohaShan",
				}, "123456");
				var mohaUser = await userManager.FindByNameAsync("MohaShan");

				await userManager.AddToRoleAsync(mohaUser, "Admin");

			}

			if ((await userManager.FindByNameAsync("User1")) == null)
			{
				await userManager.CreateAsync(new Models.User
				{
					UserName = "User1",
				}, "123456");
				var user1 = await userManager.FindByNameAsync("User1");

				await userManager.AddToRoleAsync(user1, "Client");

			}
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login()
		{
			if (HttpContext.User.Identity.IsAuthenticated)
			{
				return RedirectToAction("Index", "Product");
			}
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(Models.ViewModels.LoginVM model)
		{

			if (ModelState.IsValid)
			{
				var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Product");
				}
				ModelState.AddModelError(string.Empty, "Invalid Login Attemp");
			}
			return View(model);

		}

		[Authorize]
		public async Task<IActionResult> Signout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Login");
		}
	}
}
