using System.Collections.Generic;
using System.Linq;
using JumpersForGoalposts.Data.Contracts;
using JumpersForGoalposts.Data.Providers;
using NUnit.Framework;

namespace Jumpers.Data.UnitTests.Providers
{
    [TestFixture]
    public class SquadProviderTests
    {
        [Test]
        public void GetSquad_ExpectMoreThanOnePlayer()
        {
            IEnumerable<IPlayer> squad = SquadProvider.GetSquad();

            int actual = squad.Count();

            Assert.Greater(actual, 0);
        }
    }
}