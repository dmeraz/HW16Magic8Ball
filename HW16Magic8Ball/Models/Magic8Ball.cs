using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace HW16Magic8Ball.Models
{
    public class Magic8Ball
    {
        //create an array of strings for responses from .txt file

        StreamReader magic8ballanswers = new StreamReader("..\\..\\..\\magic8ballanswers.txt");
        string responses;

        //get random number

        public string getResponse()
        {
            
            string[] responses = { magic8ballanswers.ReadLine() };

            //get random controller object
            Random randomNum = new Random();
            int num = randomNum.Next(0, responses.Length); //may be int or var
            return responses[num];

        }
    }
}