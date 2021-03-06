﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public string UserName { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
    }

}