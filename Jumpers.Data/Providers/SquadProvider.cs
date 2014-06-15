using System.Collections.Generic;
using Jumpers.Data.Contracts;
using Jumpers.Data.Entities;

namespace Jumpers.Data.Providers
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