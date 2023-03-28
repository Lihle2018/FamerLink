using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// The VendorTag model is used to establish a many-to-many relationship between Vendor and Tag models, where each vendor can have multiple tags and each tag can be associated with multiple vendors
    /// </summary>
    public sealed class VendorTag
    {
        public int VendorTagId { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
