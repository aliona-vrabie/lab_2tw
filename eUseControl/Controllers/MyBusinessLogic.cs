using System;
using eUseControl.BusinnessLogic;
using eUseControl.BusinnessLogic.Interfaces;

namespace eUseControl.BusinnessLogic
{
	public class MyBusinessLogic
	{
		public ISession GetSessionBL()
		{
			return new SessionBL();
		}
	}
}