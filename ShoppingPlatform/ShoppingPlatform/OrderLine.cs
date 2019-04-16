namespace ShoppingPlatform
{
    public class OrderLine
    {
        private Amount amount;

        public OrderLine(Amount amount)
        {
            this.amount = amount;
        }

        public decimal AddToTotal(decimal total)
        {
            return this.amount.AddToTotal(total);
        }
    }
}