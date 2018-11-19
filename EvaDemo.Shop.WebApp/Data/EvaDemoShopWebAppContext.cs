using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaDemo.Shop.Models;

namespace EvaDemo.Shop.WebApp.Models
{
    public class EvaDemoShopWebAppContext : DbContext
    {
        public EvaDemoShopWebAppContext (DbContextOptions<EvaDemoShopWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EvaDemo.Shop.Models.User> User { get; set; }
    }
}
