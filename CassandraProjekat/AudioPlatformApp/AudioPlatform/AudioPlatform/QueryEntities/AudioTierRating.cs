using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlatform.QueryEntities
{
    public class AudioTierRating
    {
        /*PRIMARY KEY(description,customer_email)*/
        public string description { get; set; }
        public double evaluation { get; set; }
        public string customer_name { get; set; }
        public string customer_surname { get; set; }
        public string customer_email { get; set; }
        public string platform { get; set; }
    }
}
