namespace _15._1_Product_store
{
    public class Shop
    {
        private List<Product> products;

        public Shop()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            products.RemoveAll(product => product.Id == productId);
        }

        public Product GetProductById(int productId)
        {
            return products.Find(product => product.Id == productId);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}