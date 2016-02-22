using Adapter.Sites;

namespace Adapter.Adapters
{
    public class OdnoklassnikiAdapter: IAdapter
    {
        private readonly IOdnoklassniki _odnoklassniki;

        public OdnoklassnikiAdapter(IOdnoklassniki odnoklassniki)
        {
            _odnoklassniki = odnoklassniki;
        }

        public string Name
        {
            get { return _odnoklassniki.Name; }
        }

        public int Age
        {
            get { return _odnoklassniki.Age; }
        }

        public int NumberOfFriends
        {
            get { return _odnoklassniki.FriendsCount; }
        }
    }
}
