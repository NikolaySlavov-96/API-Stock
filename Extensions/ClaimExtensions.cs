using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StockAPI.Extensions
{
    public static class ClaimExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.Claims.SingleOrDefault(x => x.Type.Equals("")).Value;
        }
    }
}