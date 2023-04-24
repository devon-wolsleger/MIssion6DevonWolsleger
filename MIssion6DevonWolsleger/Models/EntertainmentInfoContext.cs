using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EntertainmentInfoContext : DbContext
    {
        public EntertainmentInfoContext(DbContextOptions<EntertainmentInfoContext> options) : base (options)
        {
        }

        public DbSet<Entertainers> Entertainers { get; set; }

    }
}
