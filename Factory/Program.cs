using Factory.Models.OnlineStores;
using Factory.Scripts;
using Factory.Services.OrderAcceleration;
using Factory.Services.Payment;
using Factory.Services.Shipping;

// Setup Dependencies.
IPaymentService paymentService = new BasicPaymentService();
IShippingService shippingService = new FedexShippingService();
OrderAccelerationService orderAccelerationService = new OrderAccelerationService();

//IOnlineStoreFactory onlineStoreFactory = new BasicOnlineStoreFactory(paymentService, shippingService);
IOnlineStoreFactory onlineStoreFactory = new FastOnlineStoreFactory(paymentService, shippingService, orderAccelerationService);


// Setup Scripts.
CreateOnlineStoreScript CreateOnlineStore = new(onlineStoreFactory);
UpdateOnlineStoreScript UpdateOnlineStore = new(onlineStoreFactory);

// Execute create script.
IOnlineStore store = CreateOnlineStore.Run();
store.OrderItem("Sean", "Motherboard");

// Execute update script.
store = UpdateOnlineStore.Run();
store.OrderItem("Sean", "CPU");