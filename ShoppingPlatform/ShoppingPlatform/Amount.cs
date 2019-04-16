namespace ShoppingPlatform
{
    public class Amount
    {
        private readonly decimal _value;

        public Amount(decimal value)
        {
            _value = value;
        }

        public decimal AddToTotal(Quantity quantity, decimal total)
        {
            return quantity.Multiply(_value) + total;
        }
    }
}