namespace EShop.Order
{
    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public ShoppingCartItem(Product Product)
        {
            this.Product = Product;
            this.Quantity = 1;
        }

    }
}
