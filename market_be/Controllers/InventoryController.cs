using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using market_be.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace market_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var inventoryItems = _service.AddInventoryItems(items);

            if (inventoryItems == null)
            {
                return NotFound();
            }
            return inventoryItems;
        }
    }
}