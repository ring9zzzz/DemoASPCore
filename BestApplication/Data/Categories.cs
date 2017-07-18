using System;
using System.Collections.Generic;

namespace BestApplication.Data
{
    public partial class Categories
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ManufacturerId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
