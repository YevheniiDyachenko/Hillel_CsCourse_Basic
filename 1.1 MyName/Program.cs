namespace _1._1_MyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string textStart = "Мене звуть ";
            string textEnd = "Я навчаюсь у школі Hillel";
            string name = "Євгеній";
            Console.WriteLine ($"{textStart} {name}");
            Console.WriteLine ($"{textEnd}");
            Console.Read();
        }
    }
}
