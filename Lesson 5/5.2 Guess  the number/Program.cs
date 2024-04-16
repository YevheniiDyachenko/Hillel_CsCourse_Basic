namespace _5._2_Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number from 1 to 146.
            int randomNumber = GenerateNumber();

            // Get the user's guess.
            Console.WriteLine("Guess a number from 1 to 146:");
            int guess = Convert.ToInt32(Console.ReadLine());

            // If the guess is incorrect, prompt the user to guess again.
            while (guess != randomNumber)
            {
                Console.WriteLine(guess < randomNumber
                    ? "Your guess is too low. Guess again:\t"
                    : "Your guess is too high. Guess again:\t");
                 
                guess = Convert.ToInt32(Console.ReadLine());
            }
            
            // If the guess is correct, display a success message.
            Console.WriteLine("You guessed the number!");
            Console.ReadLine();
        }

        // Random class for generating coefficients
        static int GenerateNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 147); //147 - because the Random.Next method generates a random number between the lower bound (inclusive) and the upper bound (exclusive).
        }
    }
}