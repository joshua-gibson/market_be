using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace market_be.Models
{
    public class InventoryItems
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public double price { get; set; }
    }
}
