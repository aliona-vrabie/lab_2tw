using eUseControl.Domain.Entities.User;

namespace eUseControl.Controllers
{
	internal interface ISession
	{
		object UserLogin(ULoginData data);
	}
}