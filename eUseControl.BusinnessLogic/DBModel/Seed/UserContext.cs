using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinnessLogic.DBModel.Seed
{
	public class UserContext : DbContext
	{
		public UserContext() :
			base("name=eUseControl")
		{
		}
		public virtual DbSet<UsersDbTable> Users { get; set; }

	}
}
