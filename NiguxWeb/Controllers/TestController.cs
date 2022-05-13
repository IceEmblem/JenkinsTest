using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiguxWeb.Controllers
{
    [Route("api/mircservice/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public int Get() {
            return 1;
        }
    }
}
