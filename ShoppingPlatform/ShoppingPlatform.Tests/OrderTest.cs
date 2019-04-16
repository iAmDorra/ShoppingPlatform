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
            int quantity = 1;
            var orderLine = new OrderLine(amount, quantity);
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
            int quantity = 1;
            var orderLine = new OrderLine(amount, quantity);
            var orderLine2 = new OrderLine(amount, quantity);
            var orderLines = new List<OrderLine>
            {
                orderLine,
                orderLine2
            };
            var order = new Order(orderLines);
            decimal total = order.CalculateTotal();
            Check.That(total).IsEqualTo(value * 2);
        }

        [TestMethod]
        public void Should_Return_Product_Price_When_Order_Contains_One_Order_Line_with_Quantity_equal_to_two()
        {
            var value = 13;
            var amount = new Amount(value);
            int quantity = 2;
            var orderLine = new OrderLine(amount, quantity);
            var orderLines = new List<OrderLine>
            {
                orderLine
            };
            var order = new Order(orderLines);
            decimal total = order.CalculateTotal();
            Check.That(total).IsEqualTo(value * quantity);
        }
    }
}
