using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace ShoppingPlatform.Tests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Should_Return_Zero_When_No_Product_In_Order()
        {
            var orderLines = new List<OrderLine>();
            var order= new Order(orderLines);
            decimal total = order.CalculateTotal();
            Check.That(total).IsEqualTo(0);
        }
    }
}
