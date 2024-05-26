namespace _14._1_PluginManager;

public class CalculatorPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("Enter a number: ");
        var num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter another number: ");
        var num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter an operation (+, -, *, /): ");
        var operation = Console.ReadLine();

        double result;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }

                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    } 
}