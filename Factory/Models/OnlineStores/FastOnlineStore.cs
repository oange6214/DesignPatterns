using Factory.Services.OrderAcceleration;
using Factory.Services.Payment;
using Factory.Services.Shipping;

namespace Factory.Models.OnlineStores
{
    public class FastOnlineStore : IOnlineStore
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        private readonly OrderAccelerationService _orderAccelerationService;

        public string Name { get; }

        public FastOnlineStore(string name, IPaymentService paymentService, IShippingService shippingService, OrderAccelerationService orderAccelerationService)
        {
            Name = name;
            _paymentService = paymentService;
            _shippingService = shippingService;
            _orderAccelerationService = orderAccelerationService;
        }

        public void OrderItem(string buyerName, string itemName)
        {
            Console.WriteLine($"'{Name}' received an order!");

            _orderAccelerationService.AccelerateOrder();

            Console.WriteLine("Rapidly verifying order.");

            _paymentService.ProcessPayment(buyerName);
            _shippingService.ProcessOrder(buyerName, itemName);

            Console.WriteLine("Order complete");
        }
    }
}
