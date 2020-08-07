using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectStorage;
using Logic;

namespace ConnectStorageDll
{
    public class ConnectStorage
    {
        private List<ConnectInChats> _connectInChats;
        private List<UserConnect> _userOutsideChats;

        public ConnectStorage()
        {
            _connectInChats = new List<ConnectInChats>();
            _userOutsideChats=new List<UserConnect>();
        }
    }
}
