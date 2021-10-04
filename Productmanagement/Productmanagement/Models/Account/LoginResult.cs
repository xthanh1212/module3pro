﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productmanagement.Models.Account
{
    public class LoginResult
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public bool Success => !string.IsNullOrEmpty(UserId);
        public string Message { get; set; }
    }
}
