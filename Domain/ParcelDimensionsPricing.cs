using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ParcelDimensionsPricing
    {
        public Guid ParcelDimensionsPricingId { get; set; }

        public decimal ParcelDimensionsCmFrom { get; set; }

        public decimal ParcelDimensionsCmTo { get; set; }

        public decimal ParcelDimensionsPrice { get; set; }


        // Relation with Courier
        public Guid CourierId { get; set; }
        public Courier Courier { get; set; }
    }
}
