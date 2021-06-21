using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman game.");
            Console.WriteLine("This is a guessing game where you guess the secret word.");
            Console.WriteLine("Guess the whole word or the letters in it. You have 10 tries." + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine);
            List<string> word = new List<string> { "cap", "car", "lady", "dance", "number", "shoe", "drive" };
            StringBuilder wrongguessedletters = new StringBuilder();
            Random r = new Random();
            string wordholder = "";
            char letterinput = '0';
            string wordinput = "";
            string playagain = "y";
            string fullword = "";
            string choice = "";
            int tries = 0;

            while (playagain == "y")
            {
                tries = 10;
                wordholder = word[r.Next(0, 6)];
                char[] guessedletters = new char[wordholder.Length];
                for(int i = 0; i < wordholder.Length; i++ )
                {
                     guessedletters[i] += '-';
                }
                string chartostringGL = new string(guessedletters);
                StringBuilder SBchartostringGL = new StringBuilder(chartostringGL);
                //Console.WriteLine(wordholder);
                Console.WriteLine("A secret word has been chosen.");

                while (tries > 0 && wordholder != wordinput && wordholder != fullword)
                {
                    Console.WriteLine("Press 1 and enter to guess a letter in the word.");
                    Console.WriteLine("Press 2 and enter to guess the whole word.");
                    Console.WriteLine("You have " + tries + (" tries" + System.Environment.NewLine));
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Guess a letter in the secret word and then press enter");
                        letterinput = Convert.ToChar(Console.ReadLine());
                        bool find = wordholder.Contains(letterinput);
                        if (find == true)
                        {
                            Console.WriteLine("Your guess was correct. Press enter");
                            int position = wordholder.IndexOf(letterinput);
                            SBchartostringGL[position] = letterinput;
                            fullword = SBchartostringGL.ToString();
                            Console.WriteLine(SBchartostringGL + System.Environment.NewLine);
                            tries--;
                        }
                        if (find == false)
                        {
                            Console.WriteLine("Your guess is incorrect. Press enter");
                            wrongguessedletters.Append(letterinput);
                            Console.WriteLine("These are your wrong guessed letters [" + wrongguessedletters + "]" + System.Environment.NewLine);
                            tries--;
                        }
                    }
                    if (choice == "2")
                    {
                        Console.WriteLine("Go ahead hotshot, try and guess the whole word and then press enter");
                        wordinput = Console.ReadLine();
                        if (wordinput == wordholder)
                        {
                            Console.WriteLine("You guessed the whole word correctly (O_O)! Press enter." + System.Environment.NewLine);
                            tries--;
                        }
                        if (wordinput != wordholder)
                        {
                            Console.WriteLine("Your guess was incurrect. Press enter" + System.Environment.NewLine);
                            tries--;
                        }
                    }
                    Console.ReadKey();

                }
                if (wordholder.Contains(SBchartostringGL.ToString()))
                {
                    Console.WriteLine("You guessed the right word. Good job!");
                    Console.WriteLine("To play again type y and press enter, or to end program type n and press enter." + System.Environment.NewLine);
                    playagain = Console.ReadLine();
                }
                if (wordinput == wordholder)
                {
                    Console.WriteLine("You guessed the right word. Good job!");
                    Console.WriteLine("To play again type y and press enter, or to end program type n and press enter." + System.Environment.NewLine);
                    playagain = Console.ReadLine();
                }
                if (tries < 1)
                {
                    Console.WriteLine("Game Over! You ran out of tries");
                    Console.WriteLine("To play again type y and press enter, or to end program type n and press enter." + System.Environment.NewLine);
                    playagain = Console.ReadLine();
                }
            }
        }
    }
}
