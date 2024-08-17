using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIStock.Model
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        [column(TypeName = "decimal(18,2)")]
        public decimal Purchase{ get; set; }
        [column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }
        public long MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}