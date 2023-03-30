using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynEdu.DataAccess.CQRS.Queries
{
    public abstract class QueryBase<IResult>
    {
        public abstract Task<IResult> Execute();
    }
}
