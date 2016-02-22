using Adapter.Sites;

namespace Adapter.Adapters
{
    public class FacebookAdapter: IAdapter
    {
        private readonly IFaceBook _faceBook;

        public FacebookAdapter(IFaceBook faceBook)
        {
            _faceBook = faceBook;
        }

        public string Name
        {
            get { return _faceBook.Name; }
        }

        public int Age
        {
            get { return _faceBook.Age; }
        }

        public int NumberOfFriends
        {
            get { return _faceBook.FriendsCount; }
        }
    }
}
