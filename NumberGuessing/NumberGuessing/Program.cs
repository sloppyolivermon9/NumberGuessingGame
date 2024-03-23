namespace NumberGuessing
{
    internal class Program
    {
        static string determineReply(int guess, int numberToGuess)
        {
            if (guess > numberToGuess)
            {
                return "Lower";
            } else
            {
                return "Higher";
            }
        }
        static bool testInput(string input)
        {
            if (input == null)
            {
                return false;
            } else
            {
                try
                {
                    if (int.Parse(input) > 100 || int.Parse(input) < 1)
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
        static int generateNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 101);
        }
        static void Main(string[] args)
        {
            int numberToGuess = generateNumber();
            Console.WriteLine("Number Guessing!\nI am thinking of a number between 1 and 100");

            int guess = 0;
            int numberOfGuesses = 0;
            while (guess != numberToGuess)
            {
                numberOfGuesses++;
                Console.WriteLine("Enter a guess:");
                string cguess = "";
                while (testInput(cguess) == false)
                {
                    cguess = Console.ReadLine();
                    if (testInput(cguess) == false)
                    {
                        Console.WriteLine("Wrong Input: Please enter another guess");
                    }
                }
                guess = int.Parse(cguess);
                if (guess != numberToGuess)
                {
                    Console.WriteLine(determineReply(guess, numberToGuess));
                }
            }
            Console.WriteLine("You guessed the number!\nIt took you " + numberOfGuesses.ToString() + " guesses!");
        }
    }
}