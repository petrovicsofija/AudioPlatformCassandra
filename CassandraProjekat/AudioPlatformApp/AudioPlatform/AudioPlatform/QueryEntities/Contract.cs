using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlatform.QueryEntities
{
    public class Contract
    {
        //PRIMARY KEY(start_date,customer_name,customer_surname,audio_tier)
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string audio_tier { get; set; }
        public string customer_name{ get; set; }
        public string customer_surname { get; set; }
    }
}
