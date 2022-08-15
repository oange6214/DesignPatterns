namespace DesignPatterns.Models.OnlineStores
{
    public interface IOnlineStore
    {
        string Name { get; }
        void OrderItem(string buyerName, string itemName);
    }
}
