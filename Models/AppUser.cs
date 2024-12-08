using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StockAPI.Models
{
    public class AppUser : IdentityUser
    {
        // public int Risk { get; set; }
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}