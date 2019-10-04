using System;
using System.Collections.Generic;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // /*
            //     You want to track the following about each word:
            //         word, definition, part of speech, example sentence

            //     Example of one dictionary in the list:
            //     {
            //         "word": "excited",
            //         "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
            //         "part of speech": "adjective",
            //         "example sentence": "I am excited to learn C#!"
            //     }
            // */
            Dictionary<string, string> stern = new Dictionary<string, string>();
            stern.Add("word", "stern");
            stern.Add("definition", "back part of a ship");
            stern.Add("part of speech", "noun");
            stern.Add("example sentence", "The boat has a large stern.");

            dictionaryOfWords.Add(stern);

            Dictionary<string, string> knobber = new Dictionary<string, string>();
            knobber.Add("word", "knobber");
            knobber.Add("definition", "a stag in its second year");
            knobber.Add("part of speech", "noun");
            knobber.Add("example sentence", "That knobber is a young buck.");

            dictionaryOfWords.Add(knobber);

            // Iterate your list of dictionaries and output the data. You can use the two foreach() loops below to help you start your iteration.

            Console.WriteLine("Dictionary of Words");
            Console.WriteLine("--------------------");

            foreach(Dictionary<string, string> word in dictionaryOfWords)
            {
                foreach(KeyValuePair<string, string> kvp in word)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
                Console.WriteLine("--------------------");
            }

        }
    }
}

