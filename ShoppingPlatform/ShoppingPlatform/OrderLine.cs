namespace ShoppingPlatform
{
    public class OrderLine
    {
        private readonly Amount _amount;
        private readonly int _quantity;

        public OrderLine(Amount amount, int quantity)
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