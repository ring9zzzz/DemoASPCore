using System;
using System.Collections.Generic;

namespace BestApplication.Data
{
    public partial class Promotions
    {
        public int Id { get; set; }
        public string PromotionName { get; set; }
        public DateTime PromotionTime { get; set; }
        public long PercentPromotion { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
