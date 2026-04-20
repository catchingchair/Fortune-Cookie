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
            // input them all into a list 
            int RandomNum = new Random().Next(0, fortuneList.Count);
            // console check
            Console.WriteLine("checking random fortune.");
            // set a new string = to the new fortune
            string fortune = fortuneList[RandomNum];
            //remove the fortune form the list
            fortuneList.RemoveAt(RandomNum);
            // send it
            return fortune;
            
        }

        public void ResetFortuneList()
        {
            // clear list
            fortuneList.Clear();
            // read from the text files that contains the list of fortunes
            foreach (string line in File.ReadLines("Fortunes.txt"))
            {    
                fortuneList.Add(line);
            }
        }
    }
}


