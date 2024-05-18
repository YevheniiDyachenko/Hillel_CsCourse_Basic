namespace _12._1_Transport;

public class Automobile: Transport
{
    public int NumberofDoors { get; set; }

    public Automobile(string title, double maximumSpeed, int numberofDoors ) : base(title, maximumSpeed)
    {
        NumberofDoors = numberofDoors;
    }
    
    public override void Move()
    {
        Console.WriteLine($"The auto {Title} has {NumberofDoors} doors and moves at {MaximumSpeed} km/h.");
    }
}