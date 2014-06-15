using Jumpers.Data.Contracts;
using Jumpers.Data.Entities;

namespace Jumpers.Data.Providers
{
    public static class UserProvider
    {
        public static IUser GetUser(int id)
        {
            return new User {UserId = id};
        }
    }
}