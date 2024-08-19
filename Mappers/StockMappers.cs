using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockAPI.Dtos.Stock;
using StockAPI.Models;

namespace StockAPI.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                Company = stockModel.Company,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                MarketCap = stockModel.MarketCap,
            };
        }

        public static Stock ToStockFromCreateDto(this CreateStockDto stockDto)
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                Company = stockDto.Company,
                Purchase = stockDto.Purchase,
                LastDiv = stockDto.LastDiv,
                MarketCap = stockDto.MarketCap,
            };
        }
    }
}