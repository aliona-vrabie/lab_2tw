using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eUseControl.Domain.Entities.User;

namespace eUseControl.Web.Extension
{
    public static class HppContextExtension
    {
        public static UserMinimal GetMySessionObject(this HttpContext current)
        {
            return (UserMinimal)current?.Session["_SessionObject"];
        }

        public static void SetMySessionObject(this HttpContext current, UserMinimal profile)
        {
            current.Session.Add("_SessionObject", profile);
        }
    }
}