namespace ShoppingPlatform
{
    public class OrderLine
    {
        private readonly Amount _amount;
        private readonly Quantity _quantity;

        public OrderLine(Amount amount, Quantity quantity)
        {
            _amount = amount;
            _quantity = quantity;
        }

        public Amount AddTo(Amount total)
        {   
            return this._amount.AddQuantityAmountToTotal(_quantity, total);
        }
    }
}