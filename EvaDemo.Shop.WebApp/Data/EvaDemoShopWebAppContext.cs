using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EvaDemo.Shop.WebApp.Models
{
    public class EvaDemoShopWebAppContext : DbContext
    {
        public EvaDemoShopWebAppContext (DbContextOptions<EvaDemoShopWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EvaDemo.Shop.WebApp.Models.Product> Product { get; set; }
    }
}
