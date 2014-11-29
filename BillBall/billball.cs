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

        public void parse(String textToParse)
        {
            const String apiKey = "7cfafa1ba04746ecbcf902540f3037d1";
            // replace all spaces in the phrase with plus so that it performs the lookup correctly
            textToParse.Replace('+', ' ');

            var jsonString = new System.Net.WebClient().DownloadString("http://capitolwords.org/api/1/dates.json?phrase=" + textToParse + "&granularity=year&apikey=" + apiKey);
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
