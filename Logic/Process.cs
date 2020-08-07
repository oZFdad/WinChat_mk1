
using ConnectStorage = ConnectStorageDll.ConnectStorage;

namespace Logic
{
    public class Process
    {
        private ConnectStorage _connectStorage;

        public Process()
        {
            _connectStorage = new ConnectStorage();
        }
    }
}