using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinessLogic.Core;
using eUseControl.BusinnessLogic.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinnessLogic
{
	class UserRegisterBL : UserApi, IRegister
	{
		public URegisterResp UserRegisterAction(UsersDbTable user)
		{
			return RegisterState(user);
		}

		private URegisterResp RegisterState(UsersDbTable user)
		{
			throw new NotImplementedException();
		}
	}
}
