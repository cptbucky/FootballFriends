using JumpersForGoalposts.Data.Contracts;
using JumpersForGoalposts.Data.Providers;
using NUnit.Framework;

namespace Jumpers.Data.Tests.Providers
{
    [TestFixture]
    public class UserProviderTests
    {
        [Test]
        public void GetUser_WithValidId_ExpectUserWithProvidedIdReturn()
        {
            int expectedId = 5;

            IUser actual = UserProvider.GetUser(expectedId);

            Assert.AreEqual(actual.Id, expectedId);
        }
    }
}