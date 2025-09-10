using APIContracts.DTOs;
using APIContracts.DTOs.StoreItems.Common;
using Contracts.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Xml.Linq;


namespace BMTH_Application__back_end_.Controllers
{
    [ApiController]
    [Route("store")]


    public class StoreController : ControllerBase
    {
        [HttpGet("items")]
        public IActionResult GetItems()
        {
            var items = new List<StoreItemDto>
            {
                new TShirtDetailsDto(1, "black thee", 9,99)
            };

            return Ok(items);
        }
    }
}

