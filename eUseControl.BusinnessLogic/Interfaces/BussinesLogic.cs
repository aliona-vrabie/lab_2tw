using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinnessLogic.Interfaces;

namespace eUseControl.BusinnessLogic
{
	public class BussinesLogic
	{
		public ISession GetSessionBL()
		{
			return new SessionBL();
		}
	}
}
