using System;
using Avalonia;
using System.Collections.Generic;
using System.IO;

namespace Fortune_Cookie
{
    public class Fortunes
    {
        public List<string> fortuneList = new List<string>{};
        
        public string getRandomFortune()
        {
            // read from the text files that contains the list of fortunes
            foreach (string line in File.ReadLines("Fortunes.txt"))
            {    
                fortuneList.Add(line);
            }
            // input them all into a list 
            int RandomNum = new Random().Next(0, fortuneList.Count);
            
            Console.WriteLine("checking random fortune.");
            return fortuneList[RandomNum];
            // hello
        }
    }
}


