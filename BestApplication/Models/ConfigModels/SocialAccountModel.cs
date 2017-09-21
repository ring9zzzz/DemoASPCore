using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestApplication.Models.ConfigModels
{
    public class SocialAccountModel
    {
        public class Facebook {
            public string FacebookId { get; set; }
            public string FacebookSecret { get; set; }

        }

        public class Google {
            public string FacebookId { get; set; }
            public string FacebookSecret { get; set; }
        }

    }
}
