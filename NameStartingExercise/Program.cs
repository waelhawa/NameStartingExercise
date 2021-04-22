using System;
using System.Collections.Generic;

namespace NameStartingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            bool checker = false;
            List<string> names = new List<string>
            {
                "Liam", "Oliver", "Noah", "William", "James", "Luke", "Ethan", "Daniel", "David", "Nancy", "Mary"
            };
            List<string> newNames;
            letter = CharInput("Please input an alphabetic character: ", "Your input is incorrect. Please input a character only.\n");
            newNames = NamesStartingWith(names, letter);
            foreach (string name in newNames)
            {
                if (!String.IsNullOrEmpty(name))
                {
                    checker = true;
                }
            }
            Console.WriteLine(String.Format("--{0}\n{1} {2,30}", $"{letter.ToString().ToUpper()}", "Original", $"Names that start with {letter.ToString().ToUpper()}"));
            if (checker)
            {  
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].ToLower()[0] == letter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(String.Format("{0} {1,15}", $"{ names[i]}", $"{ newNames[i]}"));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(String.Format("{0}", $"{names[i]}"));
                        //Console.WriteLine(String.Format("{0} {1,15}", $"{ names[i]}", $"{newNames[i]}"));
                        /*
                        */
                    }
                }
            }
            else
            {
                Console.Beep();
                Console.WriteLine("\nNo names start with this letter.");

            }

        } //end main

        public static List<string> NamesStartingWith(List<string> names, char letter)
        {
            List<string> namesWithLetter = new List<string>();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].ToLower().StartsWith(letter))
                {
                    namesWithLetter.Add(names[i]);
                }
                else
                {
                    namesWithLetter.Add("");
                }
            }
            return namesWithLetter;
        } //end NamesStartingWith

        public static char CharInput(string phrase, string error)
        {
            char letter;
            string text = "";
            while (true)
            {
                Console.Write(phrase);
                text = Console.ReadLine();
                if (Char.IsLetter(text[0]) && text.Length == 1)
                {
                    letter = text.ToLower()[0];
                    return letter;
                }
                else
                {
                    Console.WriteLine(error);
                }

            }
        } //end CharInput
    }
}
