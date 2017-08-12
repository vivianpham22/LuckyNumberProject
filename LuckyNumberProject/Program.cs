using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int jackpot = 100000;
            int lessJackpot = 200;

            // PART 1
            Console.ForegroundColor = ConsoleColor.Red;
            string text = "Welcome To Lucky's Jackpot!";
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
            Console.ResetColor();

            string jackpot2 = "Today's Jackpot is: $ ";
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(jackpot2 + jackpot);


            Console.WriteLine("\nPlease enter a low number that is 0 or higher");
            int lowNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter a higher number");
            int highNumber = int.Parse(Console.ReadLine());


            // This is the loop 
            // Asking for 6 numbers
            int[] sixGuess = new int[6];
            Console.WriteLine("\nPick your 6 LUCKY numbers!");
            for (int i = 0; i <= sixGuess.Length - 1; i++)
            {
                   
                {                             
                    Console.WriteLine("Enter a number");
                    sixGuess[i] = int.Parse(Console.ReadLine());
          
                }

                while (sixGuess[i] < lowNumber || sixGuess[i] > highNumber)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPlease enter a number between: " + lowNumber + "-" + highNumber);
                    Console.ResetColor();
                    break;
                }

            }
            // PART 2
            // Generating 6 random lucky numbers from computer
            // Must be stored in array

            Random randomNumber = new Random();
            int[] luckyNumber = new int[6];
            for (int j = 0; j < luckyNumber.Length; j++)
            {
                luckyNumber[j] = randomNumber.Next(lowNumber, highNumber);

            }
            foreach (int num in luckyNumber) //<---printing element in luckyNumber array
            {
                Console.WriteLine("Lucky Number:" + num); 

            }


            // PART 3
            // HARD CODE || Numbers correctly guessed
            int correctNumbers = 0;
            for (int k = 0; k < sixGuess.Length; k++)

            {
                //Console.WriteLine("You guessed " + correctNumbers + " numbers correctly");
                // Console.WriteLine("Lucky number: " + k);

                foreach (int number in sixGuess)
                {
                    if (number == luckyNumber[k])
                    {
                        correctNumbers += 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("\nYou guessed " + correctNumbers + " numbers correctly");

            if (correctNumbers == 6)
            {
                Console.WriteLine("\nYOU DID IT! YOU WON " + jackpot + "!");
            }
            else if (correctNumbers >= 5)
            {
                Console.WriteLine("\nGreat job you! You just won $" + lessJackpot);
            }
            else if (correctNumbers >= 4)
            {
                Console.WriteLine("\nSweet! You just won $" + lessJackpot / 2);
            }
            else if (correctNumbers >= 0)
            {
                Console.WriteLine("\nSorry! You didn't hit the jackpot. \nThere's always next time!");
            }


            // Ask the player if they want to play again
            string playAgain;
            do
            {
                Console.WriteLine("\nWould you like to play again? YES/NO");
                playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "NO")
                {
                    Console.WriteLine("\nThanks for playing!");
                }

            }
            while (playAgain == "YES");
            return;






        }
    }
}
