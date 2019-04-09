using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Users()
        {
            return new string[] { "value1", "value12" };
        }

        [HttpGet("{id}")]
        public JsonResult Get()
        {
            return new JsonResult(new { Id = 123, Name = "Hero" });
        }
    }
}
