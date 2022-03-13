using JobListings.DAO.JobListingsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain;
using Microsoft.EntityFrameworkCore;
using Mapster;

namespace JobListings.DAO.JobListingServiceImpl
{
    public class JobListingService : IJobListing
    {
        private readonly JobContext _jobContext;

        public JobListingService(JobContext jobContext)
        {
            this._jobContext = jobContext;
        }

        public async Task<JobListing> CreateJobListing(JobListing jobListing)
        {
            await this._jobContext.AddAsync(jobListing);
            await this._jobContext.SaveChangesAsync();
            return jobListing;
        }

        public async Task<JobListing> DeleteJobListing(JobListing jobListing)
        {
            this._jobContext.JobListing.Remove(jobListing);
            await this._jobContext.SaveChangesAsync();
            return jobListing;
        }

        public async Task<JobListing> GetJobListing(Guid id)
        {
            return await this._jobContext.JobListing.Where(_ => _.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<JobListing>> GetJobListings()
        {
            return await this._jobContext.JobListing.ToListAsync();
        }

        public async Task<bool> JobListingExist(Guid id)
        {
            return await this._jobContext.JobListing.AnyAsync(_ => _.Id == id);
        }

        public async Task<JobListing> UpdateJobListing(JobListing jobListing, JobListing jobListingToUpdate)
        {
            jobListing = jobListing.Adapt(jobListingToUpdate);
            this._jobContext.Update(jobListing);
            await this._jobContext.SaveChangesAsync();
            return jobListing;
        }
    }
}
