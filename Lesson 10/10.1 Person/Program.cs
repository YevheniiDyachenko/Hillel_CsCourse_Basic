namespace _10._1_Person;
class Program
{
    static void Main()
    {
        //Using UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Create an object with a complete set of data
        Person person1 = new Person("Ivan", 25, "man");
        person1.PrintDetails();
        Console.WriteLine($" Is an adult: {person1.IsAdult()}");
        person1.ChangeName("Misha");
        Console.WriteLine("Updated information:");
        person1.PrintDetails(); // Updated output with new name
        Console.WriteLine();

        // Creating an object with only a name
        Person person2 = new Person("Maria");
        person2.PrintDetails();
        Console.WriteLine($" Is an adult: {person2.IsAdult()}");
        Console.WriteLine("Updated information:");
        person2.ChangeName("Anna");
        person2.PrintDetails(); // Updated output with new name
        Console.WriteLine();

        // Create an object with a name and age
        Person person3 = new Person("Sofia", 17);
        person3.PrintDetails();
        Console.WriteLine($" Is an adult: {person3.IsAdult()}");
        Console.WriteLine("Updated information:");
        person3.ChangeName("Elisa");
        person3.PrintDetails(); // Updated output with new name
        Console.WriteLine();
    }
}