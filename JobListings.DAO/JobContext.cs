using Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListings.DAO
{
    public class JobContext : DbContext
    {

        public readonly ILoggerFactory MyLoggerFactory;

        public JobContext() {
            MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        }

        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }

        public virtual DbSet<JobListing> JobListing { get; set; }

        public override ValueTask DisposeAsync()
        {
            return base.DisposeAsync();
        }

    }
}
