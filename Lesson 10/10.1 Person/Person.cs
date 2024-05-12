namespace _10._1_Person;

public class Person
{
    private string name;
    private int age;
    private string gender;

    //1.Constructors
    /*
     //I have created three constructors, but in this case we can use only one, for example:
    public Person(string name, int age = 0, string gender = "not specified")
   {
       this.name = name;
       this.age = age;
       this.gender = gender;
   }
   */

    // Constructor that accepts name, age, and gender
    public Person(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    // A constructor that takes only a name
    public Person(string name) : this(name, 0, "not specified")
    {
    }

    // Constructor that accepts only name and age
    public Person(string name, int age) : this(name, age, "not specified")
    {
    }

    //2.Methods
    //The "PrintDetails()" method that displays information about a person (name, age, and gender).
    public void PrintDetails()
    {
        Console.WriteLine($" Name: {name},\n Age: {age},\n Gender: {gender}");
    }
    
    //The "IsAdult()" method, which returns true if the person is 18 years old or older, and false otherwise.
    public bool IsAdult()
    {
        return age >= 18;
    }
    
    //The "ChangeName()" method, which allows you to change the name of a person.
    // Maybe it's better to use the Get Set property here instead of the method?
    public void ChangeName(string newName)
    {
        name = newName;
    }
}