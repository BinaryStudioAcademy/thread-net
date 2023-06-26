using Thread_.NET.BLL.Exceptions;
using Thread_.NET.Common.Logic.Abstractions;

namespace Thread_.NET.Logic
{
    public class UserIdStorage : IUserIdGetter, IUserIdSetter
    {
        private int _id;

        public int CurrentUserId { get => _id; }

        public int GetCurrentUserIdStrict()
        {
            if (_id == 0)
            {
                throw new InvalidTokenException("No token with userId was passed");
            }

            return _id;
        }

        public void SetUserId(int userId)
        {
            _id = userId;
        }
    }
}
