using DesignPatterns.Services.Payment;
using DesignPatterns.Services.Shipping;

namespace DesignPatterns.Models.OnlineStores
{
    public class BasicOnlineStore : IOnlineStore
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public string Name { get; }

        public BasicOnlineStore(string name, IPaymentService paymentService, IShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
            Name = name;
        }

        public void OrderItem(string buyerName, string itemName)
        {
            Console.WriteLine($"'{Name}' received an order!");

            Console.WriteLine("Verifying order.");
            Thread.Sleep(500);

            _paymentService.ProcessPayment(buyerName);
            
            _shippingService.ProcessOrder(buyerName, itemName);

            Console.WriteLine("Order complete");
        }
    }
}
