using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System.Models;

namespace Pharmacy_Management_System.Models
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> options)
            : base(options)
        {
        }

        public DbSet<Pharmacy_Management_System.Models.product> Product { get; set; }
        public DbSet<Pharmacy_Management_System.Models.customer> Customer { get; set; }

    }
}