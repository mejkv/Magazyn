using MagazynEdu.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynEdu.DataAccess.CQRS.Queries
{
    public class GetDevicesQuery : QueryBase<List<Device>>
    {

        public int Id { get; set; }

        public override Task<List<Device>> Execute(WarehouseStorageContext context)
        {
            return context.Devices.ToListAsync();
        }
    }
}
