using Api.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListings.DAO
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {
        }

        public virtual DbSet<JobListing> JobListing { get; set; }

    }
}
