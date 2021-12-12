using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UITP_UGoriZhyve.Models
{
    public class SkiContext : DbContext
    {
        public DbSet<SkiComplect> SkiComplects { get; set; }
        public DbSet<ReserveRecreation> ReserveRecreations { get; set; }
    }
}