using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace rar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Words = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a word");
                var input = Console.ReadLine();
                Words.Add(input);

            }
            var results = Logic.Views(Words);
            foreach (var result in results)
            {

                Console.WriteLine(result);
            }

        }

    }










}