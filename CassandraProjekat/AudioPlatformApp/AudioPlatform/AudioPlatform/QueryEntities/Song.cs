using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlatform.QueryEntities
{
    public class Song
    {
        //PRIMARY KEY(name,autor,audio_tier)
        public string name { get; set; }
        public string autor { get; set; }
        public string url { get; set; }
        public string genre { get; set; }
        public string audio_tier { get; set; }
    }
}
