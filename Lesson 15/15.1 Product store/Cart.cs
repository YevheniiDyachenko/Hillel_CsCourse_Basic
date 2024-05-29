namespace _15._1_Product_store
{
    public class Cart
    {
        private List<Product> productsCart;

        public Cart()
        {
            productsCart = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            productsCart.Add(product);
        }

        public void RemoveFromCart(int productId)
        {
            productsCart.RemoveAll(product => product.Id == productId);
        }

        public void CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in productsCart)
            {
                totalPrice += product.Price;
            }

            Console.WriteLine($"Total price: {totalPrice}");
        }

        public void GetProducts()
        {
            foreach (Product product in productsCart)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }

            Console.WriteLine();
        }

        public List<Product> GetProductsCart()
        {
            return productsCart;
        }
    }
}