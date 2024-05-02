using System;

namespace _8._1_ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the initial total cost to zero
            decimal totalCost = 0;

            // Display a welcome message
            Console.WriteLine("Welcome to the Shopping Cart App!");

            // Loop until the user decides to stop entering items
            while (true)
            {
                // Display the menu options
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Finish entering");

                // Get the user's choice
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                // Process the user's choice
                switch (choice)
                {
                    case 1:
                        totalCost = AddNewProduct(totalCost);
                        break;
                    case 2:
                        FinishEntering(totalCost);
                        Console.WriteLine("Thank you for using the Shopping Cart App!. Press any key to exit.");
                        Console.ReadLine();
                        return; // Exit the program after finishing entering items
                    
                    default:
                        // Handle invalid choices
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            }
        }

        static decimal AddNewProduct(decimal totalCost)
        {
            // Get the product type from the user
            Console.Write("Enter product type (1=Food, 2=Clothing, 3=Electronics, 4=Books): ");
            int typeInput = int.Parse(Console.ReadLine());

            // Check if the entered value corresponds to an existing ProductType enum value
            if (Enum.IsDefined(typeof(ProductType), typeInput))
            {
                // Get the product price from the user
                Console.Write("Enter product price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                totalCost += price;
            }
            else
            {
                Console.WriteLine("Invalid product type. Please try again.");
            }

            return totalCost;
        }

        static void FinishEntering(decimal totalCost)
        {
            // Finish entering items and display the invoice
            Console.WriteLine($"Total cost: {totalCost}");
        }
    }
}
