using rar;
using System;
using System.Security.Cryptography.X509Certificates;

namespace rar
{
    public class Logic
    {

        public static List<string> Views(List<string> Words)
        {
            List<string> result = Words;
            
            //Return the list that came in 
               
            
            Words.Sort();
            result.AddRange(Words);

            Words.Reverse();
            result.AddRange(Words);
           
            //Words.OrderBy(x => x + 1);
            //result.AddRange(Words);
            
            return result;
        }



    }




}