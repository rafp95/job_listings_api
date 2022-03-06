using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobListings.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        private readonly Logger _logger = null;

        public BaseController()
        {
            this._logger = LogManager.GetLogger(this.GetType().Name);
            this._logger.Info(this);
        }
    }
}
