namespace _15._1_Product_store
{
    public class Program
    {
        public static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // 1. Store
            // 1.1 Creating a store
            Shop store = new Shop();

            // 1.2 Adding products to the store
            Console.WriteLine("Our shop is loading...");
            InitializeShop(store);

            static void InitializeShop(Shop shop)
            {
                shop.AddProduct(new Product(1, "Apple", 1.20));
                shop.AddProduct(new Product(2, "Banana", 0.80));
                shop.AddProduct(new Product(3, "Orange", 1.50));
                shop.AddProduct(new Product(4, "Grapes", 2.50));
                shop.AddProduct(new Product(5, "Pineapple", 3.00));
                shop.AddProduct(new Product(6, "Watermelon", 4.00));

                Console.WriteLine("Products added to the shop:");
                foreach (var product in shop.GetAllProducts())
                {
                    Console.WriteLine(product);
                }
            }

            // 1.3 Finding a product by ID in the store
            Product productById = store.GetProductById(2);
            Console.WriteLine("Product found by ID:");
            Console.WriteLine(productById);

            // 1.4 Remove a product by ID from the store
            store.RemoveProduct(productById.Id);
            Console.WriteLine("Product removed from shop.");

            Console.WriteLine("Shop is loaded!");
            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome to the product shop!");

            // 2. Cart
            // 2.1 Creating a cart
            Cart cart = new Cart();

            //2.2 User menu
            while (true)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. View products in the shop");
                Console.WriteLine("2. Add product to cart");
                Console.WriteLine("3. Remove product from cart");
                Console.WriteLine("4. View products in cart");
                Console.WriteLine("5. View total price in cart");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ViewProducts();
                        break;
                    case 2:
                        AddProductToCart(store, cart);
                        break;
                    case 3:
                        RemoveProductFromCart(cart);
                        break;
                    case 4:
                        ViewCart(cart);
                        break;
                    case 5:
                        ViewTotalPrice(cart);
                        break;
                    case 0:
                        Exit();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }


            // 2.3 View products in the Shop
            void ViewProducts()
            {
                Console.WriteLine("Products available in the shop:");
                foreach (var product in store.GetAllProducts())
                {
                    Console.WriteLine(product);
                }
            }

            // 2.4 Add product to cart
            static void AddProductToCart(Shop shop, Cart cart)
            {
                Console.Write("Enter product ID to add to cart: ");
                int productId = int.Parse(Console.ReadLine());
                Product product = shop.GetProductById(productId);
                if (product != null)
                {
                    cart.AddToCart(product);
                    Console.WriteLine("Product added to cart.");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }

            // 2.5 Remove product from cart
            static void RemoveProductFromCart(Cart cart)
            {
                Console.Write("Enter product ID to remove from cart: ");
                int productId = int.Parse(Console.ReadLine());
                cart.RemoveFromCart(productId);
                Console.WriteLine("Product removed from cart.");
            }


            // 2.6 View products in cart
            static void ViewCart(Cart cart)
            {
                Console.WriteLine("\nProducts in cart:");
                foreach (var product in cart.GetProductsCart())
                {
                    Console.WriteLine(product);
                }
            }

            // 2.7 View total price in cart
            static void ViewTotalPrice(Cart cart)
            {
                double totalPrice = cart.CalculateTotalPrice();
                Console.WriteLine($"Total price of products in cart: {totalPrice:C}");
            }

            // 2.8 Exit
            static void Exit()
            {
                Console.WriteLine("Exiting...");
            }
        }
    }
}