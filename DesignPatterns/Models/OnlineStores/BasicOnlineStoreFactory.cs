using DesignPatterns.Services.Payment;
using DesignPatterns.Services.Shipping;

namespace DesignPatterns.Models.OnlineStores
{
    public class BasicOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public BasicOnlineStoreFactory(IPaymentService paymentService, IShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public IOnlineStore CreateOnlineStore(string name)
        {
            return new BasicOnlineStore(name, _paymentService, _shippingService);
        }
    }
}
