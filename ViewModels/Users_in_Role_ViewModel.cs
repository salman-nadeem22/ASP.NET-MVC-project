﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechProject.ViewModels
{
    public class Users_in_Role_ViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public String AuthenticationType { get; set; }
    }
}