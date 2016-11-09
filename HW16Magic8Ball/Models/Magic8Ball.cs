using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;

namespace HW16Magic8Ball.Models
{
    public class Magic8Ball
    {
        ////Open StreamReader
        //StreamReader magic8ballanswers = new StreamReader("..\\..\\..\\magic8ballanswers.txt");

        ////Store each line of text (a prediction) in a variable
        //string responses = magic8ballanswers.ReadLine();

        public string getResponse()
        {
            //create an array of strings for responses from .txt file
            //while (magic8ballanswers != null)
            {
                string[] responses = { "Prediction1", "Prediction2", "Prediction3" };

                //get random number
                //get random controller object
                Random randomNum = new Random();
                int num = randomNum.Next(0, responses.Length); //may be int or var
                return responses[num];
            }
        }
    }
}