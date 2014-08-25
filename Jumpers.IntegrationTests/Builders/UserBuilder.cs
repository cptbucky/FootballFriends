using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using Jumpers.Data.Contracts;
using Jumpers.Data.Entities.Access;

namespace Jumpers.Integration.Tests.Builders
{
    public class UserBuilder : IUser
    {
        public int? Id { get; private set; }
        public string Email { get; set; }

        public List<ITeam> Teams { get; set; }

        public UserBuilder()
        {
            Teams = new List<ITeam>();
        }

        public UserBuilder WithEmail(string email)
        {
            Email = email;

            return this;
        }

        public UserBuilder FollowingTeams(int teamCount)
        {
            for (int i = 0; i < teamCount; i++)
            {
                Teams.Add(new Team { Name = "team" + i });
            }

            return this;
        }

        public IUser Build()
        {
            return this;
        }

        public void Persist()
        {
            using (var dataModel = new DataModel())
            {
                DbRawSqlQuery<decimal> query = dataModel.Database.SqlQuery<decimal>("INSERT INTO dbo.Users (Email) VALUES (@email); Select Scope_Identity()", new SqlParameter("@email", Email));

                Id = Convert.ToInt32(query.FirstOrDefault());

                var teamBuilder = new TeamBuilder();

                foreach (var team in Teams)
                {
                    teamBuilder.WithNameAndUserId(team.Name, this.Id).Persist();
                }
            }
        }

        public void Delete()
        {
            using (var dataModel = new DataModel())
            {
                dataModel.Database.ExecuteSqlCommand("DELETE FROM dbo.Users WHERE Email = @email", new SqlParameter("@email", Email));
            }
        }

        public static bool Exists<TV>(TV value)
        {
            using (var dataModel = new DataModel())
            {
                DbRawSqlQuery<User> users = dataModel.Database.SqlQuery<User>("SELECT * FROM dbo.Users WHERE UserId = @id", new SqlParameter("@id", value));

                return users.Any();
            }
        }

        public static void Delete(string email)
        {
            using (var dataModel = new DataModel())
            {
                dataModel.Database.ExecuteSqlCommand("DELETE FROM dbo.Users WHERE Email = @email", new SqlParameter("@email", email));
            }
        }

        public static User Get(string email)
        {
            using (var dataModel = new DataModel())
            {
                return dataModel.Database.SqlQuery<User>("SELECT * FROM dbo.Users WHERE Email = @email", new SqlParameter("@email", email)).FirstOrDefault();
            }
        }
    }
}