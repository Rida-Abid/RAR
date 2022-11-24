using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace rar;
{



    public class program
    {
        public static string Main(string[] args)
        {

            List<string> Words = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a word");
                var input = Console.ReadLine();
                Words.Add(input);
            }
            
            

            foreach (var item in Words)
            {
                return (item);
            }

            program sort = new program();

            Words.Sort();
            foreach (var item in Words)
            {
                return item;
            }

            program reverse = new program();

            Words.Reverse();
            foreach (var item in Words)
            {
                 return item;
            }

                    //Words.OrderBy(x => x);

            

            
        
    }
}