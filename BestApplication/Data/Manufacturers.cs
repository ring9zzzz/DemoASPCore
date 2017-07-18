using System;
using System.Collections.Generic;

namespace BestApplication.Data
{
    public partial class Manufacturers
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerCode { get; set; }
        public string Country { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
