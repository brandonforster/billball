using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BillBall
{
    class Parser
    {
        //public string key = "7cfafa1ba04746ecbcf902540f3037d1";
        //http://capitolwords.org/api/1/dates.json?phrase=united+states&apikey=<7cfafa1ba04746ecbcf902540f3037d1>

        public void parse()
        {
            var jsonString = new System.Net.WebClient().DownloadString("http://capitolwords.org/api/1/dates.json?phrase=united+states&granularity=year&apikey=7cfafa1ba04746ecbcf902540f3037d1");
            Data data = JsonConvert.DeserializeObject<Data>(jsonString);
            data.results();
        }
    }
}
