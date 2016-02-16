using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Management.Repository
{
    public interface IGenericRepository<TE> where TE : class
    {
        int Insert(TE e);
        int Update(TE e);
        int Delete(int id);
        TE GetById(int id);
        IEnumerable<TE> GetAll();
        List<TE> Search(Expression<Func<TE>> e);
    }
}