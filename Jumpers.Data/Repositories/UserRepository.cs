using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Jumpers.Data.Contracts;
using Jumpers.Data.Entities.Access;

namespace Jumpers.Data.Repositories
{
    internal class UserRepository : EntityFrameworkRepository<User, int>, IUserRepository
    {
        public UserRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public new IUser GetById(int id)
        {
            return base.GetById(id);
        }

        public IUser GetByEmail(string email)
        {
            var query = DbContext.Database.SqlQuery<User>("SELECT TOP(1) * FROM dbo.Users WHERE Email = @email", new SqlParameter("@email", email));

            return query.FirstOrDefault();
        }

        public IUser Create(IUser entity)
        {
            var user = new User
            {
                Email = entity.Email
            };

            base.Create(user);

            base.Save();

            return user;
        }

        public void Update(IUser entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(IUser entity)
        {
            var user = base.GetById(entity.Id.Value);

            base.Delete(user);

            base.Save();
        }
    }
}