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
        private Form1 mainWindow;

        public Parser(Form1 mainWindow)
        {
            this.mainWindow = mainWindow;
        }
        //public string key = "7cfafa1ba04746ecbcf902540f3037d1";

        public void parse()
        {
            var jsonString = new System.Net.WebClient().DownloadString("http://capitolwords.org/api/1/dates.json?phrase=united+states&granularity=year&apikey=7cfafa1ba04746ecbcf902540f3037d1");
            mainWindow.writeToDatabox(jsonString);
            var data = JsonConvert.DeserializeObject<results>(jsonString);
           
        }   
    }
}
