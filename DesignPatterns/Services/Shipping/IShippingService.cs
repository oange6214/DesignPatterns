namespace DesignPatterns.Services.Shipping
{
    public interface IShippingService
    {
        void ProcessOrder(string buyerName, string itemName);
    }
}
