namespace _2._1_Discount_Amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal price = 100;
            byte discount = 49;
            
            Console.WriteLine("Enter the item price (press Enter to use default price):");
            string input = Console.ReadLine();

            if (input != "") // when user click Enter , then use base value for price 
            {
                price = Convert.ToDecimal(input);
            }

            decimal totalPrice = price * discount / 100;

            Console.WriteLine($" Item price: {price} UAH \n Discunt: {discount}% \n Total price:{totalPrice} UAH !!!");
            Console.ReadLine();
        }
    }
}
