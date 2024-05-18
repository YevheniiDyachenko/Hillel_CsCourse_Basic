namespace _12._1_Transport;

public class Transport
{
    public string Title { get; set; }
    public double MaximumSpeed { get; set; }

    public Transport(string title, double maximumSpeed)
    {
        Title = title;
        MaximumSpeed = maximumSpeed;
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Title} is moving at {MaximumSpeed} km/h.");
    }
}