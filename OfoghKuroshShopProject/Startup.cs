﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfoghKuroshShopProject.Models;

namespace OfoghKuroshShopProject
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new MappingProfile());
			});

			IMapper mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);
			services.AddAuthorization();

			services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));


			services.AddIdentity<User, Role>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

			services.Configure<IdentityOptions>(options =>
			{
				// Password settings
				options.Password.RequireDigit = false;
				options.Password.RequiredLength = 3;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = false;
				options.Password.RequireLowercase = false;
				options.Password.RequiredUniqueChars = 1;

				// Lockout settings
				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
				options.Lockout.MaxFailedAccessAttempts = 10;
				options.Lockout.AllowedForNewUsers = true;

				// User settings
				options.User.RequireUniqueEmail = false;
			});

			services.ConfigureApplicationCookie(options =>
			{
				// Cookie settings
				options.Cookie.HttpOnly = true;
				options.Cookie.Expiration = TimeSpan.FromDays(150);
				// If the LoginPath isn't set, ASP.NET Core defaults 
				// the path to /Account/Login.
				options.LoginPath = "/Account/Login";
				// If the AccessDeniedPath isn't set, ASP.NET Core defaults 
				// the path to /Account/AccessDenied.
				options.AccessDeniedPath = "/Account/AccessDenied";
				options.SlidingExpiration = true;
			});



			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();
			app.UseAuthentication();
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Account}/{action=Login}/{id?}");
			});
		}
	}
}
