using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eUseControl.Domain.Entities.User;

namespace eUseControl.Web.Models
{
	public class UserData
	{
		public string Username { get; set; }

		public List<string> Products { get; set; }

		public string SingleProducts { get; set; }
		public URole Level { get; internal set; }
	}
}