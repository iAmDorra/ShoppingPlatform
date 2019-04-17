using System.Collections.Generic;

namespace ShoppingPlatform
{
    public class Order
    {
        private readonly List<OrderLine> _orderLines;

        public Order(List<OrderLine> orderLines)
        {
            _orderLines = orderLines;
        }

        public Amount CalculateTotal()
        {
            Amount total = new Amount(0);
            foreach (var orderLine in _orderLines)
            {
                total = orderLine.AddTo(total);
            }
            return total;
        }
    }
}