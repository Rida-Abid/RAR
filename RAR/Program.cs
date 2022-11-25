using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace rar
{
    class Program
    {

        /*
            Improvement tasks
            1. What if the user didnt pass any parameters when running the code. What would the result be and is it correct ?
            2. Think of how to make this more flexible, ie remove the fixed limit of 5.
               How else can this be done.(hint: maybe pass all the words in via the command line as parameters)
            3. Remember KISS philosophy (Keep It Simple Silly) - your Views method is doing too much 
               It should do just 1 thing very well.
            4. Consider how you would do random and lets discuss different ways to achieve this. (hint: maybe extend the List class)
            5. Try to create blank methods with no code inside, and then write the test scripts, before writing the code inside the methods.
            6. Cann the lists be displayed separately, ie with a blank line between them.
         
         */

        public static void Main(string[] args)
        {
            List<string> Words = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a word");
                var input = Console.ReadLine();
                Words.Add(input);
            }

            var results = new Logic().Views(Words);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

    }










}