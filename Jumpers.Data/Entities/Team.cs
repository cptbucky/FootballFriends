using Jumpers.Data.Contracts;

namespace Jumpers.Data.Entities.Access
{
    public partial class Team : ITeam
    {
        public int? Id { get { return TeamId; } }
    }
}