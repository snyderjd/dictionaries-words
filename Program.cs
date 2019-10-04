using System;
using System.Collections.Generic;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary with key value pairs to represent words (key) and their definitions (value)

            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("stern", "back part of a ship");
            wordsAndDefinitions.Add("knobber", "a stag in its second year");
            wordsAndDefinitions.Add("upas", "poisonous or harmful institution or influence");
            wordsAndDefinitions.Add("exodist", "one who goes out; emigrant");

            // Use square brackets to get the definition of two of the words and then output them to the console
            Console.WriteLine(wordsAndDefinitions["stern"]);
            Console.WriteLine(wordsAndDefinitions["knobber"]);

            // Loop over the wordsAndDefinitions dictionary to get the following output:
            //   The definition of (WORD) is (DEFINITION)

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}.");
            }
        }
    }
}

