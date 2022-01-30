using Application.CommandQuery.Couriers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class CouriersController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Courier>>> GetCouriers()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourier(Courier courier)
        {
            return Ok(await Mediator.Send(new Create.Command { Courier = courier }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditCourier(Guid id, Courier courier)
        {
            // Set Courier Id
            courier.CourierId = id;
            return Ok(await Mediator.Send(new Edit.Command { Courier = courier }));
        }
    }
}
