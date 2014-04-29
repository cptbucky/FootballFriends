using JumpersForGoalposts.Data.Contracts;
using JumpersForGoalposts.Data.Entities;

namespace JumpersForGoalposts.Data.Providers
{
    public static class UserProvider
    {
        public static IUser GetUser(int id)
        {
            return new User(id);
        }
    }
}