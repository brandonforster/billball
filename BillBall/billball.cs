using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections;


namespace BillBall
{
    public class billball
    {
        private const string DICTIONARY_FILENAME= "dictionary.txt";

        private Form1 mainWindow;
        private ArrayList resultsList;
        private string[] dictionary;
        private string sourceWord;

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

            this.resultsList = new ArrayList();

            // pull from the dictionary of source words. This should be a textfile in the same directory.
            setSourceWord();

            this.mainWindow = new Form1(this);

            Application.Run(mainWindow);
        }

        public void setSourceWord()
        {
            this.dictionary = System.IO.File.ReadAllLines(DICTIONARY_FILENAME);

            // pick a random word from the dictionary
            Random rnd = new Random();
            this.sourceWord= dictionary[rnd.Next(0, this.dictionary.Length)];
        }

        public string getSourceWord()
        {
            return this.sourceWord;
        }

        public Form1 getWindow()
        {
            return this.mainWindow;
        }

        public void setWindow(Form1 newWindow)
        {
            this.mainWindow = newWindow;
        }

        public int getWordScore(String textToParse)
        {
            int wordScore= 0;

            const String apiKey = "7cfafa1ba04746ecbcf902540f3037d1";
            // replace all spaces in the phrase with plus so that it performs the lookup correctly
            textToParse.Replace('+', ' ');

            var jsonString = new System.Net.WebClient().DownloadString("http://capitolwords.org/api/1/dates.json?phrase=" + textToParse + "&granularity=year&apikey=" + apiKey);
            RootObject data = JsonConvert.DeserializeObject<RootObject>(jsonString);
            if (data == null)
                Console.WriteLine("Please enter a string to check!");
            else
            {
                wordScore = data.getCount();
                string result = "" + wordScore;
            }

            resultsList.Add(data);

            return wordScore;
        }   
    }
}
