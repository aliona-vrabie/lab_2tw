using System;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinnessLogic.Interfaces;

namespace eUseControl.BusinnessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }

        public IRegister GetRegisterBL()
        {
            return new UserRegisterBL();
        }
    }
}