using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Package
    {
        public Guid PackageId { get; set; }


        // Package Dimensions
        public decimal PackageWidth { get; set; }
        public decimal PackageHeight { get; set; }
        public decimal PackageDepth { get; set; }


        // Pakcage Weight
        public decimal PackageWeight { get; set; }


        // Relation with Courier
        public Guid CourierId { get; set; }
        public Courier Courier { get; set; }
    }
}
