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
            6. Can the lists be displayed separately, ie with a blank line between them.
            
            1. Check if user has input words
            2. Create a list 
            3. Store the values input by user  
            4. For random list use rnd(0, args.Length)

            
         */

        public static void Main(string[] args)
        {
                     
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter in some words");
            }
            else
            {
                var logic = new Logic();
                List<string> Words = args.ToList();

                DisplayValues("Displaying origional list", Words);

                DisplayValues("Displaying sorted list", logic.SortedList(Words));

                DisplayValues("Displaying list in reverse", logic.Reverse(Words));

                DisplayValues("Displaying random words from the list", logic.Randomise(Words));

            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }


        private static void DisplayValues(string heading, List<string> Words)
        {
            Console.WriteLine(heading);
            Console.WriteLine("-----------------------------");
            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }










}