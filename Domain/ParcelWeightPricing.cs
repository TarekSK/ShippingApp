using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ParcelWeightPricing
    {
        public Guid ParcelWeightPricingId { get; set; }

        public decimal ParcelWeightKgFrom { get; set; }

        public decimal ParcelWeightKgTo { get; set; }

        public decimal ParcelWeightPrice { get; set; }

        // Check To Add [Price Per Each KG In This Pricing Record]
        public bool ParcelWeightIsAddKgPrice { get; set; }

        // Price Per KG To Be Added If Wanted
        public decimal ParcelKgPrice { get; set; } = 0;


        // Relation with Courier
        public Guid CourierId { get; set; }
        public Courier Courier { get; set; }
    }
}
