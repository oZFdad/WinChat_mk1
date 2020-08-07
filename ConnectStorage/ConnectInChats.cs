using Logic;
using System.Collections.Generic;

namespace ConnectStorage
{
    internal class ConnectInChats
    {
        private string _name;
        private List<UserConnect> _userConnects;

        internal ConnectInChats()
        {
            _name = "No name";
            _userConnects = new List<UserConnect>();
        }

        internal void CreateUser(UserConnect userConnect)
        {
            _userConnects.Add(userConnect);
        }

        internal bool DeleteUserConnect (UserConnect userConnect)
        {
            return _userConnects.Remove(userConnect);
        }

        internal List<UserConnect> GetUserConnects()
        {
            return _userConnects;
        }
    }
}