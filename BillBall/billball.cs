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
        private ArrayList scores; //Array of scores, 10 is spare, 11 is strike
        private string[] dictionary;
        private string sourceWord;
        private int score;
        private int frame;
        private int bowlInFrame;
        private int pinsLeft;

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

            startGame();

            this.mainWindow = new Form1(this);

            Application.Run(mainWindow);
        }

        //A function to set up the game loop
        public void startGame()
        {
            // pull from the dictionary of source words. This should be a textfile in the same directory.
            score = 0;
            frame = 1;
            bowlInFrame = 1;
            pinsLeft = 10;
            setSourceWord();
            scores = new ArrayList();
        }

        //Im just calling this when the game ends
        public void gameEnd()
        {
            
        }

        //Need this to be called whenever submit is pressed. 
        public void gameLoop()
        {
            //This should be how big their number is compared to the target. ie, 1.01 means its bigger
            //This can be passed in or gotten through a function
            double percent = .10;

            //how many pints the current percent gets down, based on pins left
            //Basically, split up 100 percent into number of pins left + 1
            //ie: 1 pin left is 50% for hit 50% for miss, 2 is 33% for his 2, 33% for hit 1, 33% for miss
            int thisScore = (int)(percent / (pinsLeft + 1));
            
            //Gets last two scores since they might be needed
            int secondLastScore = 0;
            int lastScore = 0;
            if(scores.Count > 1)
                secondLastScore = (int)scores[scores.Count - 2];
            if(scores.Count > 0)
                lastScore = (int)scores[scores.Count - 1];
            
            //Gutter ball
            if (percent >= 1 || thisScore == 0)
            {
                //If first shot in frame
                if (bowlInFrame == 1)
                {
                    bowlInFrame++;
                    scores.Add(0);
                }
                //If second shot and not tenth frame, move to next frame
                else if (frame < 10 && bowlInFrame == 2)
                {
                    bowlInFrame = 1;
                    frame++;
                    pinsLeft = 10;
                    scores.Add(0);
                }
                //If second shot of tenth frame and first wasnt a strike
                else if (frame == 10 && bowlInFrame == 2 && lastScore != 11)
                {
                    scores.Add(0);
                    gameEnd();
                }
                //Otherwise it is tenth frame, second shot and first was a strike
                else
                {
                    bowlInFrame++;
                }
            }

            //Last shot of the game
            else if (frame == 10 && bowlInFrame == 3)
            {
                score += thisScore;
                scores.Add(thisScore);
                gameEnd();
            }

            //Bowl 2 of frame 10
            else if (frame == 10 && bowlInFrame == 2)
            {
                score += thisScore;
                if (secondLastScore == 11)
                    score += thisScore;
                //Checks to see if a third frame is given
                if (thisScore + lastScore < 10)
                {
                    scores.Add(thisScore);
                    gameEnd();
                }
                //Checks to see if its a spare
                else if (thisScore + lastScore == 10)
                {
                    scores.Add(10);
                    bowlInFrame++;
                    pinsLeft = 10;
                }
                //Checks to see if its a strike
                else if (thisScore == 10 && lastScore == 11)
                {
                    scores.Add(11);
                    bowlInFrame++;
                    pinsLeft = 10;
                }
                //Otherwise sees if last one was a strike
                else if (lastScore == 11)
                {
                    scores.Add(thisScore);
                    bowlInFrame++;
                }
                //Otherwise its an error
                else
                    Console.WriteLine("Frame 10 bowl 2 error state");
            }

            //Bowl 2 of any other frame
            else if (bowlInFrame == 2)
            {
                frame++;
                bowlInFrame = 1;
                pinsLeft = 10;
                score += thisScore;
                if (secondLastScore == 11)
                    score += thisScore;
                //Checks for spare
                if (lastScore + thisScore == 10)
                    scores.Add(10);
                else
                    scores.Add(thisScore);
            }

            //Otherwise check to see if its bowl 1 of any frame
            else if (bowlInFrame == 1)
            {
                score += thisScore;
                if (lastScore >= 10)
                    score += thisScore;
                if (secondLastScore == 11)
                    score += thisScore;

                //Checks for strike
                if(thisScore == 10)
                {
                    scores.Add(11);
                    if (frame == 10)
                        bowlInFrame++;
                    else
                        frame++;
                }
                //Otherwise no strike
                else
                {
                    scores.Add(thisScore);
                    bowlInFrame++;
                    pinsLeft -= thisScore;
                }
            }

            //Otherwise error
            else
                Console.WriteLine("Illegal Position");

            //Testing purposes, printing game state
            Console.WriteLine("Frame: " + frame + " Pins left: " + pinsLeft + " Score: " + score);
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

        public int calcPinsHit(int srcScore, int playScore)
        {
            // what percent is the score of the play to the source?
            double percentage = ((double) playScore) / ((double) srcScore);

            // 100- 90%: strike
            if (percentage >= .9)
                return 10;

            // 89.9 - 80: 9
            else if (percentage >= .8)
                return 9;

            else if (percentage >= .7)
                return 8;

            else if (percentage >= .6)
                return 7;

            else if (percentage >= .5)
                return 6;

            // for arbitrary game design reasons, make everything
            // lower than 50% accuracy worth 1 pin less
            else if (percentage >= .4)
                return 4;

            else if (percentage >= .3)
                return 3;

            else if (percentage >= .2)
                return 2;

            else if (percentage >= .1)
                return 1;

            // gutterball! this occurs if your guess
            // is 90% off from the correct value or
            // if your guess is too high.
            else
                return 0;
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
