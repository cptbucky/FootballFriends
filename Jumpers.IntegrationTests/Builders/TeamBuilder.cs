using System;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using Jumpers.Data.Contracts;
using Jumpers.Data.Entities.Access;

namespace Jumpers.Integration.Tests.Builders
{
    public class TeamBuilder : ITeam
    {
        public int? Id { get; private set; }
        public string Name { get; set; }

        public TeamBuilder WithName(string name)
        {
            Name = name;

            return this;
        }

        public TeamBuilder WithNameAndUserId(string name, int? id)
        {
            this.WithName(name);

            this.Id = id;

            return this;
        }

        public ITeam Build()
        {
            return this;
        }

        public void Persist()
        {
            using (var dataModel = new DataModel())
            {
                DbRawSqlQuery<decimal> query = dataModel.Database.SqlQuery<decimal>("INSERT INTO dbo.Teams (Name) VALUES (@name); Select Scope_Identity()", new SqlParameter("@name", Name));

                Id = Convert.ToInt32(query.FirstOrDefault());
            }
        }

        public void Delete()
        {
            using (var dataModel = new DataModel())
            {
                dataModel.Database.ExecuteSqlCommand("DELETE FROM dbo.Teams WHERE Name = @name", new SqlParameter("@name", Name));
            }
        }

        public static bool Exists<TV>(TV value)
        {
            using (var dataModel = new DataModel())
            {
                return dataModel.Database.SqlQuery<Team>("SELECT * FROM dbo.Teams WHERE TeamId = @id", new SqlParameter("@id", value)).Any();
            }
        }

        public static void Delete(string name)
        {
            using (var dataModel = new DataModel())
            {
                dataModel.Database.ExecuteSqlCommand("DELETE FROM dbo.Teams WHERE Name = @name", new SqlParameter("@name", name));
            }
        }

        public static Team Get(string name)
        {
            using (var dataModel = new DataModel())
            {
                return dataModel.Database.SqlQuery<Team>("SELECT * FROM dbo.Teams WHERE Name = @name", new SqlParameter("@name", name)).FirstOrDefault();
            }
        }
    }
}