using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinnessLogic.Core;
using eUseControl.BusinnessLogic.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinnessLogic
{
	public class SessionBL : UserApi, ISession
	{
		public ULoginResp UserLogin(ULoginData data)
		{
			return new ULoginResp();
		}
	}
}
