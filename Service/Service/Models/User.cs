﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Models
{
    public class User
    {
        public string Email { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}
