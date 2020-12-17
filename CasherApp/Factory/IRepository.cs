using System;
using System.Collections.Generic;
using System.Linq;

namespace CasherApp.Factory
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string query);
        IEnumerable<T> GetByParam(string query, object param);
        void ExecParam(string query, object param);
        void ExecQuery(string query);
        T GetSingle(string query, object param);
    }
}
