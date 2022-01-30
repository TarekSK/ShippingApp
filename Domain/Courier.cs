using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Courier
    {
        public Guid CourierId { get; set; }

        public string CourierName { get; set; }

        // Parcel Weight - [Min, Max]
        public decimal ParcelWeightKgMin { get; set; }
        public decimal ParcelWeightKgMax { get; set; }

        // Parcel Dimensions - [Min, Max]
        public decimal ParcelDimensionCmMin { get; set; }
        public decimal ParcelDimensionCmMax { get; set; }

        // Parcel Pricing - Relation
        public List<ParcelWeightPricing> ParcelWeightPricing { get; set; }
        public List<ParcelDimensionsPricing> ParcelDimensionsPricing { get; set; }
        public List<Package> Package { get; set; }
    }
}
