using Application.CommandQuery.ParcelWeightPricing;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcelWeightPricingController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Domain.ParcelWeightPricing>>> GetParcelWeightPricings()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpPost]
        public async Task<IActionResult> CreateParcelWeightPricing(ParcelWeightPricing parcelWeightPricing)
        {
            return Ok(await Mediator.Send(new Create.Command { ParcelWeightPricing = parcelWeightPricing }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditParcelWeightPricing(Guid id, ParcelWeightPricing parcelWeightPricing)
        {
            // Set ParcelWeightPricing Id
            parcelWeightPricing.ParcelWeightPricingId = id;
            return Ok(await Mediator.Send(new Edit.Command { ParcelWeightPricing = parcelWeightPricing }));
        }
    }
}
