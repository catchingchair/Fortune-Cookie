using System;
using Avalonia;
using System.Collections.Generic;
using System.IO;

namespace Fortune_Cookie
{
    public static class Fortunes
    {
        public static List<string> fortuneList = new List<string>{};
        
        public static string getRandomFortune()
        {
            // make sure some pycho path didn't go through every single fortune 
            if(fortuneList.Count == 0)
            {
                ResetFortuneList();
            }
            // get a random fortune
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

        public static void ResetFortuneList()
        {
            // clear list
            fortuneList.Clear();
            // read from the text files that contains the list of fortunes
            foreach (string line in File.ReadLines("List/Fortunes.txt"))
            {    
                fortuneList.Add(line);
            }
        }
    }
}


