namespace _12._1_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            // The objects of the derived class
            Automobile automobile1 = new Automobile("Toyota", 365, 4);
            Bicycle bicycle1 = new Bicycle("Trek Emonda SLR 9", 35, "Road bike");
            
            //The object of the base class
            Transport transport1 = new Transport("Airplane", 1000);
            
            // The object of a derived class is created by changing the base class
            Transport automobile2 = new Automobile("Porshe", 450, 2);
            
            Console.WriteLine($"Auto: {automobile1.Title}, max speed: {automobile1.MaximumSpeed}  km/h., number of doors: {automobile1.NumberofDoors}");
            Console.WriteLine($"Bicycle: {bicycle1.Title}, max speed: {bicycle1.MaximumSpeed}  km/h., type: {bicycle1.TypeBicycle}");
            Console.WriteLine($"Transport: {transport1.Title}, max speed: {transport1.MaximumSpeed}  km/h.");
            Console.WriteLine($"Auto: {automobile2.Title}, max speed: {automobile2.MaximumSpeed}  km/h.");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Moving...");
            
            // Calling a replacement method in an object of a derived class
            automobile1.Move();
            bicycle1.Move();
            
            // Сalling a virtual method of a base class object
            transport1.Move();
            
            // Calling a replacement method in an object of a base class
            automobile2.Move();
        }
    }
}
