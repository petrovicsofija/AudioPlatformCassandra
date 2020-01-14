using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlatform.QueryEntities
{
    public class Customer
    {
        //PRIMARY KEY(email,password)
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string birth_date { get; set; }
        public string audio_tier { get; set; }
        public double audio_price { get; set; }
        public string contract_start_date { get; set; }
        public string contract_end_date { get; set; }
    }
}
