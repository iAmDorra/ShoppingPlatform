namespace ShoppingPlatform
{
    public class Quantity
    {
        private readonly int _value;

        public Quantity(int value)
        {
            _value = value;
        }

        public decimal Multiply(decimal value)
        {
            return _value * value;
        }
    }
}