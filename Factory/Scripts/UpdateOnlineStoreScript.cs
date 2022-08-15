using Factory.Models.OnlineStores;

namespace Factory.Scripts
{
    public class UpdateOnlineStoreScript
    {
        private readonly IOnlineStoreFactory _onlineStoreFactory;

        public UpdateOnlineStoreScript(IOnlineStoreFactory onlineStoreFactory)
        {
            _onlineStoreFactory = onlineStoreFactory;
        }

        public IOnlineStore Run()
        {
            Console.WriteLine("Enter your updated online store's name: ");
            string storeName = Console.ReadLine();

            IOnlineStore store = _onlineStoreFactory.CreateOnlineStore(storeName);

            return store;
        }
    }
}
