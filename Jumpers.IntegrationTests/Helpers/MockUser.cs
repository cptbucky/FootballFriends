using Jumpers.Data.Contracts;

namespace Jumpers.Integration.Tests.Helpers
{
    class MockUser : IUser
    {
        public int? Id { get; private set; }

        public string Email { get; set; }

        internal IUser WithEmail(string email)
        {
            Email = email;

            return this;
        }
    }
}