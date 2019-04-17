namespace ShoppingPlatform
{
    public class Amount
    {
        private readonly decimal _value;

        public Amount(decimal value)
        {
            _value = value;
        }

        public Amount AddQuantityAmountToTotal(Quantity quantity, Amount total)
        {
            var quantityAmount = quantity.Multiply(this);

            var totalValue = quantityAmount._value + total._value;
            return new Amount(totalValue);
        }

        public override bool Equals(object obj)
        {
            var amount = obj as Amount;
            return this._value.Equals(amount._value);
        }

        public Amount Multiply(Amount amount)
        {
            return new Amount(_value * amount._value);
        }

        public Amount Minus(Amount amount)
        {
            return new Amount(this._value - amount._value);
        }
    }
}