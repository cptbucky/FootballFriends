using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Jumpers.Data.Contracts;
using Jumpers.Data.Entities.Access;

namespace Jumpers.Data.Repositories
{
    internal class TeamRepository : EntityFrameworkRepository<Team, int>, ITeamRepository
    {
        public TeamRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public new ITeam GetById(int id)
        {
            return base.GetById(id);
        }

        public ITeam Create(ITeam entity)
        {
            var team = new Team
            {
                Name = entity.Name
            };

            base.Create(team);

            base.Save();

            return team;
        }

        public void Update(ITeam entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(ITeam entity)
        {
            var team = base.GetById(entity.Id.Value);

            base.Delete(team);

            base.Save();
        }
    }
}