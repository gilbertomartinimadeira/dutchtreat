using System;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers {

    [Route("api/products")]
    public class ProductsController : ControllerBase{

        public IActionResult Get() {
            return Ok("I'll be back...");
        }

    }
}
