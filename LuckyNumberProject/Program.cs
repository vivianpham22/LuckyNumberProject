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
            Console.WriteLine("Welcome to Lucky's Number!");
            Console.WriteLine("Today's Jackpot is: $" + jackpot);
            Console.WriteLine("Please enter a low number in the number range.");
            int lowNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a high whole number in the number range.");
            int highNumber = int.Parse(Console.ReadLine());


            // This is the loop 
            // Asking for 6 numbers
            int[] sixGuess = new int[6];
            for (int i = 0; i <= sixGuess.Length - 1; i++)
            {
                {
                    Console.WriteLine("Enter one number");          
                    sixGuess[i] = int.Parse(Console.ReadLine());
                }

                while (sixGuess[i] < lowNumber || sixGuess[i] > highNumber)
                {
                    Console.WriteLine("Please enter a number between:" + lowNumber + "-" + highNumber);
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
                luckyNumber[j] = randomNumber.Next(lowNumber, highNumber); //<-- was i suppose to put a +1 or ++ at the end of highNumber?
                
            }
            foreach (int num in luckyNumber) //<---printing element in luckyNumber array
            {
                Console.WriteLine("Lucky Number:" + num); //+ luckyNumber[j]); // + "Your Numbers:" + sixGuess[j]); 
                // why couldnt i have just put  + luckyNumbers ^
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
            Console.WriteLine("You guessed " + correctNumbers + " numbers correctly");

            if (correctNumbers == 6)
            {
                Console.WriteLine("YOU DID IT! YOU WON " + jackpot + "!");
            }
            else if (correctNumbers >= 5)
            {
                Console.WriteLine("Great job you! You just won $" + lessJackpot);
            }
            else if (correctNumbers >= 4) 
            {
                Console.WriteLine("Sweet! You just won $" + lessJackpot / 2);
            }
            else if (correctNumbers >= 0)
            {
                Console.WriteLine("Sorry! You didn't hit the jackpot. \nThere's always next time!");
            }
         

            // Ask the player if they want to play again
            string playAgain;
            do
            {
                Console.WriteLine("Would you like to play again? YES/NO");
                playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "NO")
                {
                    Console.WriteLine("Thanks for playing!");
                }

            }
            while (playAgain == "YES");







        }
    }
}
