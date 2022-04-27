using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int game = 0;
            //keeps game going until user exits
            while(game == 0)
            {
                //clears the screen at the start of each game
                Console.Clear();

                //object to count incorrect attempts
                int incorrectAttempts = 0;
                //object to count correct attempts
                int correctAttempts = 0;
                //object to restart the game when too many incorrect attempts
                string restart = "";
                //List to contain used letters
                List<string> usedLetters = new List<string>();
                //List to contain used words
                List<string> usedWords = new List<string>();

                // pick random word from list
                List<string> word = new List<string>();
                word.Add("HELLO");
                word.Add("WORLD");
                word.Add("DREAM");
                word.Add("GREAT");
                word.Add("CREAM");

                Random ran = new Random();

                //Takes random word from list
                string rdmWord = word[ran.Next(0, word.Count - 1)];
                Console.WriteLine(rdmWord);
                Console.ReadLine();

                Console.WriteLine("    Welcome to Hang Man!");

                //Creates an empty array
                string[] emptyArray = createEmptyArray(rdmWord.Length);

                Console.WriteLine("    A word has been chosen! This word has {0} letters!", rdmWord.Length);

                //Keeps game looping until too many incorrect attempts
                while (restart.Length == 0)
                {

                    int correctLetterCount = 0;

                    figureBuilder(incorrectAttempts);

                    Console.WriteLine("     You have made {0} incorrect attempt(s)! {1} chance(s) remaining!", incorrectAttempts, 6 - incorrectAttempts);

                    if (incorrectAttempts >= 6)
                    {
                        Console.WriteLine("     You have run out of attempts. Thank you for playing Hang Man!");
                        break;
                    }

                    //object to start next try
                    string nextTry = "";

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    //sets up each iteration
                    while (nextTry.Length == 0)
                    {
                        Console.Write("     Please enter a word or a letter!");
                        string input = Console.ReadLine();
                        input = input.ToUpper();

                        //if user enters a word, it checks the word to see if it matches
                        if (input.Length > 1 && wordCheck(input, rdmWord) == true)
                        {
                            Console.WriteLine("     You have guessed the word correctly! Thank you for playing Hang Man!");
                            Console.WriteLine("     Please press enter to continue");
                            restart = Console.ReadLine();
                        }
                        else if (input.Length > 1 && wordCheck(input, rdmWord) != true)
                        {
                            usedWords.Add(input);
                            Console.WriteLine("     You have guessed the word incorrectly!");
                            Console.WriteLine("     Please press enter to continue");
                            nextTry = Console.ReadLine();
                        }

                        //If user has entered a letter, it is added to the list

                        usedLetters.Add(input);

                        char[] currentWord = rdmWord.ToCharArray();

                        List<int> listofindexes = charCount(input, currentWord);

                        if((int)listofindexes[0] == -1)
                        {
                            Console.WriteLine("     This letter does not appear anywhere in the word");
                            Console.WriteLine("     Please press enter to continue");
                            nextTry = Console.ReadLine();
                        }
                        emptyArray = replaceEmptyArray(emptyArray, listofindexes, input);
                        break;
                    }

                    


                    Console.Write("     You have found these letters: ");

                    for(int i = 0; i < emptyArray.Length; i++)
                    {
                        if(emptyArray[i] != "_ ")
                        {
                            correctLetterCount++;
                        }
                        Console.Write(emptyArray[i] + " ");
                    }
                    Console.WriteLine();



                    if(usedLetters.Count > 0)
                    {
                        Console.Write("     You have used these letters: ");
                        for (int i = 0; i < usedLetters.Count; i++)
                        {
                            Console.Write(usedLetters[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    if(usedWords.Count > 0)
                    {
                        Console.WriteLine();
                        Console.Write("     You have used these words: ");
                        for (int i = 0; i < usedWords.Count; i++)
                        {
                            Console.WriteLine(usedWords[i] + ", ");
                        }
                    }

                    if(stringChecker(emptyArray, rdmWord) == true)
                    {
                        Console.WriteLine("     You have found the word!");
                        Console.WriteLine();
                        break;
                    }

                    if(correctLetterCount > 0)
                    {
                        continue;
                    }

                    incorrectAttempts++;
                }


                Console.WriteLine("     If you would like to go again, press enter. If you would like to exit press Ctrl + C.");
                Console.ReadLine();
            }

        }







        public static void figureBuilder(int n) 
        {
            int attemptcounter = n;

            switch (attemptcounter)
            {
                case 1:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 2:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 3:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 4:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\       |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 5:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\       |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 6:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\       |");
                    Console.WriteLine("           / \\       |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                default:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
            }
        }


        public static string[] createEmptyArray(int n) 
        {
            string[] arr = new string[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = "_ ";
            }
            return arr;
        }

        public static bool wordCheck(string input, string currentWord)
        {
            //converts all the letters to uppercase
            input = input.ToUpper();

            if(input == currentWord)
            {
                return true;
            }
            return false;
        }

        public static List<int> charCount(string input, char[] currentWord)
        {
            //Converts string to char array
            char[] output = input.ToCharArray();
            //Creates an array list for indexes
            List<int> indexes = new List<int>();

            for(int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i] == output[0])
                {
                    indexes.Add(i);
                }
            }
            indexes.Add(-1);
            return indexes;

            //returns list with indexes where they match else returns -1, cut off at -1
        }

        public static string[] replaceEmptyArray(string[] arr, List<int> listofindexes, string input)
        {
            for(int i = 0; i < listofindexes.Count; i++)
            {
                if((int) listofindexes[i] == -1)
                {
                    break;
                }

                for(int j = 0; j < arr.Length; j++)
                {
                    if(listofindexes[i] == j)
                    {
                        arr[j] = input;
                    }
                }
               
            }
            return arr;
        }

        public static bool stringChecker(string[] emptyArray, string input)
        {
            string test = string.Join("", emptyArray);
            if(test == input)
            {
                return true;
            }
            return false;
        }

        //public static bool duplicate wordchecker
    }
}

