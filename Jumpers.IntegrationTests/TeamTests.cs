using Jumpers.Data.Contracts;
using Jumpers.Data.Entities.Access;
using Jumpers.Data.Repositories;
using Jumpers.Integration.Tests.Builders;
using NUnit.Framework;

namespace Jumpers.Integration.Tests
{
    [TestFixture]
    public class TeamTests
    {
        private DataModel _dataModel;
        private TeamRepository _teamRepo;

        private const string FakeName = "Sith Utd";

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _dataModel = new DataModel();

            _teamRepo = new TeamRepository(_dataModel);
        }

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
            // cleanup
            TeamBuilder.Delete(FakeName);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            _dataModel.Dispose();
        }

        [Test]
        public void Create_ExpectCreated()
        {
            // setup user
            var entity = new TeamBuilder().WithName(FakeName).Build();

            var newTeam = _teamRepo.Create(entity);

            bool entityExists = TeamBuilder.Exists(newTeam.Id);

            Assert.True(entityExists);
            Assert.AreEqual(FakeName, newTeam.Name);
        }

        [Test]
        public void Delete_ExpectNoLongerExists()
        {
            // setup user
            var builder = new TeamBuilder().WithName(FakeName);

            builder.Persist();

            var team = builder.Build();

            _teamRepo.Delete(team);

            bool entityExists = UserBuilder.Exists(team.Id);

            Assert.False(entityExists);
        }

        [Test]
        public void Get_ById_ExpectNameSet()
        {
            var builder = new TeamBuilder().WithName(FakeName);

            builder.Persist();

            var dummyEntity = builder.Build();

            var entity = _teamRepo.GetById(dummyEntity.Id.Value);

            Assert.AreEqual(FakeName, entity.Name);
        }

        [Test]
        public void Get_ByUserId_ExpectThreeTeams()
        {
            var builder = new UserBuilder().FollowingTeams(3);

            builder.Persist();

            var dummyEntity = builder.Build();

            var entity = _teamRepo.GetById(dummyEntity.Id.Value);

            Assert.AreEqual(FakeName, entity.Name);
        }
    }
}