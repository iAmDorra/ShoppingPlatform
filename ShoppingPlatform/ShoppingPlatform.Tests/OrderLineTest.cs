using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace ShoppingPlatform.Tests
{
    [TestClass]
    public class OrderLineTest
    {
        [TestMethod]
        public void Should_not_apply_discount_when_quantity_is_less_than_tree()
        {
            decimal productAmount = 12;
            var unitAmount = new Amount(productAmount);
            var quantityValue = 2;
            var quantity = new Quantity(quantityValue);
            OrderLine line = new OrderLine(unitAmount, quantity);
            var initialTotal = new Amount(0);

            var total = line.AddTo(initialTotal);

            var amountValue = new Amount(productAmount * quantityValue);
            Check.That(total).IsEqualTo(amountValue);
        }

        [TestMethod]
        public void Should_apply_discount_when_quantity_is_more_than_tree()
        {
            decimal productAmount = 12;
            var unitAmount = new Amount(productAmount);
            var quantityValue = 3;
            var quantity = new Quantity(quantityValue);
            OrderLine line = new OrderLine(unitAmount, quantity);
            var initialTotal = new Amount(0);

            var total = line.AddTo(initialTotal);

            var expectedPartialTotal = productAmount * quantityValue;

            var expectedTotal = expectedPartialTotal - expectedPartialTotal * 0.20m;
            var amountValue = new Amount(expectedTotal);
            Check.That(total).IsEqualTo(amountValue);
        }
    }
}
