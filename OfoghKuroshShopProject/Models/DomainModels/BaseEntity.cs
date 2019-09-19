using System;

namespace OfoghKuroshShopProject.Models
{
	public abstract class BaseEntity<TKey> : IEntity
	{
		public TKey Id { get; set; }


		public DateTimeOffset InsertDate { get; set; }


	}

	public abstract class BaseEntity : BaseEntity<int>
	{

	}
}
