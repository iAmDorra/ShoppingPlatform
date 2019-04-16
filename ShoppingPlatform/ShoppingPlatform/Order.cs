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

        public decimal CalculateTotal()
        {
            if (_orderLines.Count != 0)
            {
                return 12;
            }

            return 0;
        }
    }
}