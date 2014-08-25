using Jumpers.Data.Contracts;
using Jumpers.Data.Entities.Access;
using Jumpers.Data.Repositories;
using Jumpers.Integration.Tests.Builders;
using NUnit.Framework;

namespace Jumpers.Integration.Tests
{
    [TestFixture]
    public class UserTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
            // cleanup
            UserBuilder.Delete(FakeEmail);
        }

        private DataModel _dataModel;
        private UserRepository _userRepo;

        private const string FakeEmail = "poo.bear@thehoneytree.com";

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _dataModel = new DataModel();

            _userRepo = new UserRepository(_dataModel);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            _dataModel.Dispose();
        }

        [Test]
        public void Create_ExpectCreated()
        {
            IUser entity = new UserBuilder().WithEmail(FakeEmail).Build();

            IUser newEntity = _userRepo.Create(entity);

            bool userExists = UserBuilder.Exists(newEntity.Id);

            Assert.True(userExists);
            Assert.AreEqual(FakeEmail, newEntity.Email);
        }

        [Test]
        public void Delete_ExpectNoLongerExists()
        {
            // setup user
            UserBuilder builder = new UserBuilder().WithEmail(FakeEmail);

            builder.Persist();

            IUser user = builder.Build();

            _userRepo.Delete(user);

            bool userExists = UserBuilder.Exists(user.Id);

            Assert.False(userExists);
        }

        [Test]
        public void Get_ByEmail_ExpectIdSet()
        {
            // setup user
            new UserBuilder().WithEmail(FakeEmail).Persist();

            IUser user = _userRepo.GetByEmail(FakeEmail);

            Assert.IsNotNull(user.Id);
        }

        [Test]
        public void Get_ById_ExpectEmailSet()
        {
            // setup user
            UserBuilder builder = new UserBuilder().WithEmail(FakeEmail);

            builder.Persist();

            IUser dummyUser = builder.Build();

            IUser user = _userRepo.GetById(dummyUser.Id.Value);

            Assert.AreEqual(FakeEmail, user.Email);
        }
    }
}