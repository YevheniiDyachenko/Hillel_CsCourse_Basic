namespace _12._1_Transport;

public class Bicycle:Transport
{
    public string TypeBicycle { get; set; }

    public Bicycle(string title, double maximumSpeed, string typeBicycle) : base(title, maximumSpeed)
    {
        TypeBicycle = typeBicycle;
    }
    
    public override void Move()
    {
        Console.WriteLine($"The bicycle {Title} of type {TypeBicycle} is moving at a speed of {MaximumSpeed} km/h.");
    }
}