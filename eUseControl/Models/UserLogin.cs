﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Models
{
    public class UserLogin
    {
        public string Credential { get; set; }
        public string Password { get; set; }
    }
}