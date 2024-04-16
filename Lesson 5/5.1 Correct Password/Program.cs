namespace _5._1_Correct_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            // ? - null-able variable
            string? password;
            do
            {
                // Get the password from the user.
                Console.WriteLine("Enter the password:");
                password = Console.ReadLine();

                // Check if the password is correct.
                if (password != "root")
                {
                    // If the password is incorrect, display an error message.
                    Console.WriteLine("Wrong password!");
                }
            } while (password != "root");

            // If the password is correct, display a success message.
            Console.WriteLine("Correct password!");
        }
    }
}