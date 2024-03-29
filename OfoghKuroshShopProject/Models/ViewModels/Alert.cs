﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfoghKuroshShopProject.Models.ViewModels
{
	public class Alert
	{
		public const string TempDataKey = "TempDataAlerts";

		public string AlertStyle { get; set; }
		public string Message { get; set; }
		public bool KeepForNextView { get; set; }
	}

	public static class AlertStyles
	{
		public const string Success = "success";
		public const string Information = "info";
		public const string Warning = "warning";
		public const string Danger = "danger";
	}
}
