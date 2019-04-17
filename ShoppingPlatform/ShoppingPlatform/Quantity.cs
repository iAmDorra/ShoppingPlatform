namespace ShoppingPlatform
{
    public class Quantity
    {
        private readonly int _value;

        public Quantity(int value)
        {
            _value = value;
        }

        public Amount Multiply(Amount amount)
        {
            return amount.Multiply(_value);
        }
    }
}