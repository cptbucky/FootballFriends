using System.Collections.Generic;
using JumpersForGoalposts.Data.Contracts;
using JumpersForGoalposts.Data.Entities;

namespace JumpersForGoalposts.Data.Providers
{
    public static class SquadProvider
    {
        public static IEnumerable<IPlayer> GetSquad()
        {
            var squad = new List<IPlayer> {new Player()};

            return squad;
        }
    }
}