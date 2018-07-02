namespace _07._Sales_Report
{
    internal class sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public sale(string Tawn, string Product, decimal Price, decimal Quantity)
        {
            this.Town = Town;
            this.Product = Product;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public decimal Multiply()
        {
            return Price * Quantity;
        }
    }
}