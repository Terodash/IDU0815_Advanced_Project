using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IDU0815Phoning.Phoning
{
    public class CallContext : DbContext
    {
        public  CallContext() : base("IDU0815Phoning")
        {
        }
        public DbSet<T_EVENT> Events { get; set; }
        public DbSet<T_CALL> Calls { get; set; }
        public DbSet<T_EVENT_TYPE> EventTypes { get; set; }
    }
}