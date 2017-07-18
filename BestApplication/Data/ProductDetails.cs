using System;
using System.Collections.Generic;

namespace BestApplication.Data
{
    public partial class ProductDetails
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime? DateOfManufacture { get; set; }
        public string FullName { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
