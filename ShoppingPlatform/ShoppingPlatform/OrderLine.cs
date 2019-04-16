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

        public decimal AddToTotal(decimal total)
        {
            return this._amount.AddToTotal(_quantity, total);
        }
    }
}