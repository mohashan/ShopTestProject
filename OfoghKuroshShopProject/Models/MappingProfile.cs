using AutoMapper;
using OfoghKuroshShopProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfoghKuroshShopProject.Models
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Add as many of these lines as you need to map your objects
			CreateMap<Product, ProductVM>();
			CreateMap<ProductVM, Product>();

			CreateMap<Order, OrderVM>()
				.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.UserName))
				.ForMember(dest => dest.ProductOrdersCount, opt => opt.MapFrom(src => src.ProductOrders.Sum(d=>d.Amount)));
			CreateMap<OrderVM, Order>();

			CreateMap<ProductOrderVM, ProductOrder>();
			CreateMap<ProductOrder, ProductOrderVM>();

			CreateMap<BasketVM, Basket>();
			CreateMap<Basket, BasketVM>();
		}
	}
}
