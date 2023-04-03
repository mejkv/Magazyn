using MagazynEdu.DataAccess.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynEdu.DataAccess
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly WarehouseStorageContext context;

        public QueryExecutor(WarehouseStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(this.context);
        }
    }
}
