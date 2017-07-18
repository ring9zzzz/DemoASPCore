using System;
using System.Collections.Generic;

namespace BestApplication.Data
{
    public partial class Guarantees
    {
        public int Id { get; set; }
        public string GuaranteeName { get; set; }
        public DateTime GuaranteeTime { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
