using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DealersApplication.Models;

namespace DealersApplication.Data
{
    public class DealersAppDBContext : DbContext
    {
        public DealersAppDBContext (DbContextOptions<DealersAppDBContext> options)
            : base(options)
        {
        }

        public DbSet<DealersApplication.Models.Dealer> Dealer { get; set; } = default!;
    }
}
