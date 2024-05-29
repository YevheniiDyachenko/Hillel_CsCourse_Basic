namespace _15._1_Product_store
{ 
    public class Program
    {
        public static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            // Creating a store
            Shop store = new Shop();
            
            // Додавання нових продуктів у магазин
            store.AddProduct(new Product(1, "Йогурт", 3.00));
            store.AddProduct(new Product(2, "Банани", 2.10)); // Оновлення існуючого продукту
            store.AddProduct(new Product(3, "Сир", 4.50));
            store.AddProduct(new Product(4, "Молоко", 1.80));


            // Отримання всіх продуктів у магазині
            Console.WriteLine("Products in shop:");
            foreach (var product in store.GetAllProducts())
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }

            // Створення кошика
            Cart cart = new Cart();

            // Додавання продуктів до кошика
            cart.AddToCart(new Product(5, "Apple", 0.5));
            cart.AddToCart(new Product(6, "Milk", 2.5));
            cart.AddToCart(new Product(7, "Bread", 1.5));

            // Отримання всіх продуктів у кошику
            Console.WriteLine("\nProducts in cart:");
            foreach (var product in cart.GetProductsCart())
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }

            // Обчислення загальної ціни продуктів у кошику
            cart.CalculateTotalPrice();
        }
    }
}