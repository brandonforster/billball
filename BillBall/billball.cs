using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace BillBall
{
    public class billball
    {
        private Form1 mainWindow;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new billball();
        }

        public billball()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            this.mainWindow = new Form1(this);

            Application.Run(mainWindow);
        }

        public Form1 getWindow()
        {
            return this.mainWindow;
        }

        public void setWindow(Form1 newWindow)
        {
            this.mainWindow = newWindow;
        }

        public void parse()
        {
            //public string key = "7cfafa1ba04746ecbcf902540f3037d1";

            var jsonString = new System.Net.WebClient().DownloadString("http://capitolwords.org/api/1/dates.json?phrase=united+states&granularity=year&apikey=7cfafa1ba04746ecbcf902540f3037d1");
            mainWindow.writeToDatabox(jsonString);
            RootObject data = JsonConvert.DeserializeObject<RootObject>(jsonString);
            if (data == null)
                mainWindow.writeToDatabox("NULL");
            else
            {
                string result = "" + data.getCount();
                mainWindow.writeToDatabox(result);
            }

        }   
    }
}
