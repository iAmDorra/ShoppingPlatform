using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using System.Collections.Generic;

namespace ShoppingPlatform.Tests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Should_Return_Zero_When_No_Product_In_Order()
        {
            var orderLines = new List<OrderLine>();
            var order = new Order(orderLines);
            decimal total = order.CalculateTotal();
            Check.That(total).IsEqualTo(0);
        }

        [TestMethod]
        public void Should_Return_Product_Price_When_Order_Contains_One_Product()
        {
            var value = 12;
            var amount = new Amount(value);
            var orderLine = new OrderLine(amount);
            var orderLines = new List<OrderLine>
            {
                orderLine
            };
            var order = new Order(orderLines);
            decimal total = order.CalculateTotal();
            Check.That(total).IsEqualTo(value);
        }

        [TestMethod]
        public void Should_Return_Product_Price_When_Order_Contains_Many_Products()
        {
            var value = 13;
            var amount = new Amount(value);
            var orderLine = new OrderLine(amount);
            var orderLine2 = new OrderLine(amount);
            var orderLines = new List<OrderLine>
            {
                orderLine,
                orderLine2
            };
            var order = new Order(orderLines);
            decimal total = order.CalculateTotal();
            Check.That(total).IsEqualTo(value * 2);
        }
    }
}
