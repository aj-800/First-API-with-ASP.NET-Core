using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/dummy")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        private CityInfoContext _ctx;

        public DummyController(CityInfoContext ctx)
        {
            _ctx = ctx;
        }


        [HttpGet("testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }

    }
}