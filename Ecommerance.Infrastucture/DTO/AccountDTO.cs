﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Infrastucture.DTO
{
    public class AccountDTO
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    }
}
