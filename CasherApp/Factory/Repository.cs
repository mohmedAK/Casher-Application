using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace CasherApp.Factory
{
    class Repository<T> : DataConnection, IRepository<T> where T : class
    {
        private IDbConnection connection = ConVal();
        public void ExecParam(string query, object param)
        {
            connection.Execute(query, param);
        }

        public void ExecQuery(string query)
        {
            connection.Execute(query);
        }

        public IEnumerable<T> GetAll(string query)
        {
            return connection.Query<T>(query);
        }

        public IEnumerable<T> GetByParam(string query, object param)
        {
            return connection.Query<T>(query, param);
        }

        public T GetSingle(string query, object param)
        {
            return connection.Query<T>(query, param).SingleOrDefault();
        }
    }
}
