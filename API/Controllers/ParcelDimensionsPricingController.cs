using Application.CommandQuery.ParcelDimensionPricing;
using Application.CommandQuery.ParcelDimensionsPricing;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcelDimensionsPricingController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Domain.ParcelDimensionsPricing>>> GetParcelDimensionsPricings()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpPost]
        public async Task<IActionResult> CreateParcelDimensionsPricing(ParcelDimensionsPricing parcelDimensionsPricing)
        {
            return Ok(await Mediator.Send(new Create.Command { ParcelDimensionsPricing = parcelDimensionsPricing }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditParcelDimensionsPricing(Guid id, ParcelDimensionsPricing parcelDimensionsPricing)
        {
            // Set ParcelDimensionsPricing Id
            parcelDimensionsPricing.ParcelDimensionsPricingId = id;
            return Ok(await Mediator.Send(new Edit.Command { ParcelDimensionsPricing = parcelDimensionsPricing }));
        }
    }
}
