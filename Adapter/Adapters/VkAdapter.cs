using Adapter.Adapters;

namespace Adapter.Sites
{
    public class VkAdapter: IAdapter
    {
        private readonly IVk _vk;

        public VkAdapter(IVk vk)
        {
            _vk = vk;
        }

        public string Name
        {
            get { return _vk.Name; } 
        }

        public int Age
        {
            get { return _vk.Age; }
        }

        public int NumberOfFriends
        {
            get { return _vk.FriendsCount; }
        }
    }
}
