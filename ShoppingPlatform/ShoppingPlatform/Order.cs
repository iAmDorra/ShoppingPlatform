using System.Collections.Generic;
using System.Linq;

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
            decimal total = 0;
            foreach (var orderLine in _orderLines)
            {
                total = orderLine.AddToTotal(total);
            }
            return total;
        }
    }
}