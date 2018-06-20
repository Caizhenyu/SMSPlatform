using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSPlatform.Models
{
    public class SMSContext : DbContext
    {
        public SMSContext(DbContextOptions<SMSContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Api> Api { get; set; }
        public DbSet<Record> Record { get; set; }
        public DbSet<UserApiExtend> UserApiExtend { get; set; }
    }
}
