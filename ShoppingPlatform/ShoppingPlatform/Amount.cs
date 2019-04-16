namespace ShoppingPlatform
{
    public class Amount
    {
        private readonly decimal _value;

        public Amount(decimal value)
        {
            _value = value;
        }

        public decimal AddToTotal(int quantity, decimal total)
        {
            return _value * quantity + total;
        }
    }
}