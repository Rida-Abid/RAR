using rar;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Xml;

namespace rar
{
    public class Logic
    {
        private object rnd;

        public List<string>SortedList(List<string> Words)
        {
            List<string> result = Words.ToList();
             //Return the list that came in 
               
           
            result.Sort();
            return result;
        }

        public List<string> Reverse(List<string> Words)
        {
            List<string> result = Words.ToList();

            result.Reverse(); 
            return result;
        }

        public List<string> Randomise(List<string> Words)
        {
            List<string> result = new List<string>();

            foreach(var w in Words)
            {
                result.Add(Words[Random(Words.Count)]);
            }
            return result;
        }

        private int Random(int max)
        {
            return new Random().Next(0, max - 1);
        }

    }




}