using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinnessLogic.Interfaces
{
	public interface IRegister
	{
		URegisterResp UserRegisterAction(UsersDbTable data);
	}
}
