using rar;
using System;
using System.Security.Cryptography.X509Certificates;

namespace rar
{
    public class Logic
    {

        public static string Views(List<string> Words)
        {
            List<string> View = new List<string>(Words);
            {


                List<string> list = new List<string>(Words);
                foreach (var item in list)
                {
                    return item;
                }

                List<string> sort = new List<string>(Words);
                Words.Sort();
                foreach (var item in sort)
                {
                    return item;
                }
                List<string> reverse = new List<string>(Words);

                Words.Reverse();
                foreach (var item in reverse)
                {
                    return item;
                }

                List<string> random = new List<string>(Words);
                Words.OrderBy(x => x + 1);
                foreach (var item in random)
                {
                    return item;
                }

            }

            return View;
        }



    }




}