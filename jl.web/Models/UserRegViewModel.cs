using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jl.web.Models
{
    public class UserRegViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}