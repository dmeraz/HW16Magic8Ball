using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Threading.Tasks;
//using System.IO;

namespace HW16Magic8Ball.Models
{
    public class Magic8Ball
    {
        //Open StreamReader
        //StreamReader magic8ballanswers = new StreamReader("C:\\Users\\WeCanCodeIT\\Documents\\Visual Studio 2015\\Projects\\HW16Magic8Ball\\magic8ballanswers.txt");

        //Store each line of text (a prediction) in a variable
        //string responses; No longer needed for List
        //int num;

        public string getResponse()
        {
            //Array of Predicitons
            string[] responses = { "It is certain", "You may rely on it", "Yes", "Better not tell you now", "My reply is no" };

            //get random number
            //get random controller object
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length); //may be int or var
            return responses[num];

            //Attempt to use StreamReader
            ////create a list of strings for responses from .txt file
            //List<string> responses = new List<string>();

            //int capacity = responses.Capacity;

            ////fill array with responses
            //using (magic8ballanswers)
            //{
            //    while (magic8ballanswers != null)
            //    {
            //        responses.Add(magic8ballanswers.ReadLine());
            //        if (responses.Capacity > capacity)
            //        {
            //            capacity = responses.Capacity;
            //        }
            //    }
            //}

            ////convert list to array
            ////string[] responsesArray = responses.ToArray();

            ////get random number
            ////get random controller object
            //Random randomNum = new Random();
            //num = randomNum.Next(0, responses.Count);
            //return responses[num];
        }
    }
}
