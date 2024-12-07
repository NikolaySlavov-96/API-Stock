using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockAPI.Models;

namespace StockAPI.Interfaces
{
    public interface ITokenService
    {
        string CreationToken(AppUser appUser);
    }
}