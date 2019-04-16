namespace ShoppingPlatform
{
    public class Amount
    {
        private readonly decimal _value;

        public Amount(decimal value)
        {
            _value = value;
        }

        public decimal AddToTotal(decimal total)
        {
            return total + _value;
        }
    }
}