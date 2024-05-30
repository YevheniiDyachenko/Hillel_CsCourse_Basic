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

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in productsCart)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }

        public List<Product> GetProductsCart()
        {
            return productsCart;
        }
    }
}