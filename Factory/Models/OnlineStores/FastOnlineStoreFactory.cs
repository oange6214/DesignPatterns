using Factory.Services.OrderAcceleration;
using Factory.Services.Payment;
using Factory.Services.Shipping;

namespace Factory.Models.OnlineStores
{
    public class FastOnlineStoreFactory : IOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        private readonly OrderAccelerationService _orderAccelerationService;

        public FastOnlineStoreFactory(IPaymentService paymentService, IShippingService shippingService, OrderAccelerationService orderAccelerationService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
            _orderAccelerationService = orderAccelerationService;
        }

        public IOnlineStore CreateOnlineStore(string name)
        {
            return new FastOnlineStore(name, _paymentService, _shippingService, _orderAccelerationService);
        }
    }
}
