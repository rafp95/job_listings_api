using Api.Domain;
using Api.Domain.DTO;
using JobListings.DAO.JobListingsService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobListings.Controllers
{

    public class JobListingsController : BaseController
    {
        private readonly IJobListing _jobListing;

        public JobListingsController(IJobListing jobListing)
        {
            this._jobListing = jobListing;
        }

        //Get All JobListings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobListing>>> GetJobListings()
        {
            return Ok(await this._jobListing.GetJobListings());
        }

        //Get a specyfic JobListing by id
        [HttpGet("id")]
        public async Task<ActionResult<JobListing>> GetJobListing(Guid id)
        {
            return Ok(await this._jobListing.GetJobListing(id));
        }
        
        [HttpPost]
        [Route("AddJobListing")]
        public async Task<ActionResult> CreateJobListing(JobListing jobListing)
        {
            return Ok(await this._jobListing.CreateJobListing(jobListing));
        }

        [HttpPost]
        [Route("UpdateJobListing")]
        public async Task<ActionResult> UpdateJobListing(JobListing jobListing)
        {
            var result = await this._jobListing.GetJobListing(jobListing.Id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(await this._jobListing.UpdateJobListing(jobListing, result));
        }

        [HttpPost]
        [Route("DeleteJobListing")]
        public async Task<ActionResult> DeleteJobListing([FromBody] GuidRequest request)
        {
            JobListing jobListing = await this._jobListing.GetJobListing(request.id);
            if (jobListing == null)
            {
                return NotFound();
            }
            return Ok(await this._jobListing.DeleteJobListing(jobListing));
        }

    }
}
