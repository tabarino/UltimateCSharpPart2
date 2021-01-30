using System;
using Xunit;
using Interfaces;

namespace Interfaces.UnitTests
{
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTATION
        [Fact]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order { Shipment = new Shipment() };

            Assert.Throws<InvalidOperationException>(
                () => orderProcessor.Process(order)
            );
        }

        [Fact]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.True(order.IsShipped);
            Assert.Equal(1, order.Shipment.Cost);
            Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
