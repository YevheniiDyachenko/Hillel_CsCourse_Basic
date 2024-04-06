namespace _2._1_Discount_Amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating and initializing variables
            decimal price = 100;
            byte discount = 49;

            //getting values from the console
            Console.WriteLine("Enter the item price (press Enter to use default price):");
            string inputPrice = Console.ReadLine();

            if (inputPrice != "") // when user click Enter , then use base value for price 
            {
                price = Convert.ToDecimal(inputPrice);
            }

            //calculation of the result
            decimal totalDiscount = price * discount / 100;
            decimal totalPrice = price - totalDiscount;
            
            //output of the result
            Console.WriteLine($" Item price: {price} UAH \n Discunt: {discount} % \n Total discount: {totalDiscount} UAH \n Total price: {totalPrice} UAH !!!");
            Console.ReadLine();
        }
    }
}
