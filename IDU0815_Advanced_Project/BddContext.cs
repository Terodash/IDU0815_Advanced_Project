using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InformationSystemsProgramming.App_Start
{
    public class BddContext : DbContext
    {
        public BddContext() : base("Information Systems Programming")
        {
        }

        public DbSet<T_CALL> T_CALL { get; set; }
        public DbSet<T_EVENT> T_EVENT { get; set; }
    }
}