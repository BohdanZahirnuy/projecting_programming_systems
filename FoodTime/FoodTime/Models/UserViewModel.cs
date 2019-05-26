﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace FoodTime.Models
{
    public class UserViewModel:IdentityUser
    {
        public string Address { get; set; }
    }
}
