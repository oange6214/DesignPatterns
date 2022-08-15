using Factory.Models.OnlineStores;

namespace Factory.Scripts
{
    public class CreateOnlineStoreScript
    {
        private readonly IOnlineStoreFactory _onlineStoreFactory;

        public CreateOnlineStoreScript(IOnlineStoreFactory onlineStoreFactory)
        {
            _onlineStoreFactory = onlineStoreFactory;
        }

        public IOnlineStore Run()
        {
            Console.Write("Enter your new oneline store's name: ");
            string storeName = Console.ReadLine();

            IOnlineStore store = _onlineStoreFactory.CreateOnlineStore(storeName);

            return store;
        }
    }
}
