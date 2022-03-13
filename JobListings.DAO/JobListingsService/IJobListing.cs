using Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobListings.DAO.JobListingsService
{
    public interface IJobListing
    {
        Task<IEnumerable<JobListing>> GetJobListings();
        Task<JobListing> CreateJobListing(JobListing jobListing);
        Task<JobListing> UpdateJobListing(JobListing jobListing, JobListing jobListingToUpdate);
        Task<JobListing> GetJobListing(Guid id);
        Task<bool> JobListingExist(Guid id);
        Task<JobListing> DeleteJobListing(JobListing jobListing);
       
    }
}
