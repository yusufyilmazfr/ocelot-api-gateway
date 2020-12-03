using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OcelotApiGateway.CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(new List<string> { "Yusuf", "Derya", "Sema" });
        }

        [HttpGet("{id:long}")]
        public IActionResult GetCustomer(long id)
        {
            return Ok(new { id = id, firstName = "Derya" });
        }
    }
}
