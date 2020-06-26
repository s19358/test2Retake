using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test2retake.Exceptions;
using test2retake.Services;

namespace test2retake.Controllers
{
    [Route("api/firefighters")]
    [ApiController]
    public class FireFighterController : ControllerBase
    {
        private readonly IFireDbService _service;

        public FireFighterController(IFireDbService service)
        {
            _service = service;
        }

        [HttpGet("{id:int}/actions")]
        public IActionResult GetActions(int id)
        {
            try
            {
                var res = _service.GetActions(id);
                return Ok(res);

            }
            catch (FireManDoesNotExistsException ex)
            {
                return NotFound(ex.Message);
            }
          
        }

      
    }
}