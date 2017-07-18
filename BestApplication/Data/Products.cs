using System;
using System.Collections.Generic;

namespace BestApplication.Data
{
    public partial class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int Price { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int CategoryId { get; set; }
        public int? GuaranteeId { get; set; }
        public int? PromotionId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
