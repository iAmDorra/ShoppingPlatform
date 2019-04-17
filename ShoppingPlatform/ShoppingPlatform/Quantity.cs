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
            var result = amount.Multiply(new Amount(_value));
            if (_value >= 3)
            {
                result = result.Minus(result.Multiply(new Amount(0.2m)));
            }
            return result;
        }
    }
}