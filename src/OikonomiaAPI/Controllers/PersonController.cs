using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>>Get()
        {
            return new string[] { "this", "is", "hard", "coded" };
        }
    }
}
