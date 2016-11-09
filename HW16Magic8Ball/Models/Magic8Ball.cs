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
        //Open StreamReader
        StreamReader magic8ballanswers = new StreamReader("..\\..\\..\\magic8ballanswers.txt");

        //Store each line of text (a prediction) in a variable
        string responses;
        int num;

        public string getResponse()
        {
            //create a list of strings for responses from .txt file
            List<string> responses = new List<string>();

            //fill array with responses
            while (magic8ballanswers != null)
            {
                responses.Add(magic8ballanswers.ReadLine());
            }

            //convert list to array

            string[] responsesArray = responses.ToArray();
            //get random number
            //get random controller object
            Random randomNum = new Random();
            num = randomNum.Next(0, responsesArray.Length);
            return responsesArray[num];
        }
        magic8ballanswers.Close();    
        }
}
}