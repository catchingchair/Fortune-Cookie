using System;
using System.Collections.Generic;
using System.IO;

namespace Fortune_Cookie
{
    public class Fortune
    {
        // The only instance of this class
        private static Fortune? _instance;

        // The list is now private so that only this class can touch it
        private List<string> _fortuneList = new List<string>();

        // Private constructor so that no outsiders can call "new Fortune()"
        private Fortune()
        {
            LoadFortunes();
        }

        // The only way into this class
        public static Fortune GetInstance()
        {
            if (_instance == null)
                _instance = new Fortune();
            return _instance;
        }

        public string GetNextFortune()
        {
            if (_fortuneList.Count == 0)
                LoadFortunes();

            int randomNum = new Random().Next(0, _fortuneList.Count);
            string fortune = _fortuneList[randomNum];
            _fortuneList.RemoveAt(randomNum);
            return fortune;
        }

        public void Reshuffle()
        {
            LoadFortunes();
        }

        // Private so that only this class can reset its own list
        private void LoadFortunes()
        {
            _fortuneList.Clear();
            foreach (string line in File.ReadLines("List/Fortunes.txt"))
            {
                _fortuneList.Add(line);
            }
        }
    }
}