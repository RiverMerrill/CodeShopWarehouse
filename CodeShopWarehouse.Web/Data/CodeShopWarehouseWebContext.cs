using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeShopWarehouse.Data;

namespace CodeShopWarehouse.Web.Models
{
    public class CodeShopWarehouseWebContext : DbContext
    {
        public CodeShopWarehouseWebContext (DbContextOptions<CodeShopWarehouseWebContext> options)
            : base(options)
        {
        }

        public DbSet<CodeShopWarehouse.Data.Order> Order { get; set; }
    }
}
