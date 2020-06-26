using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test2retake.DTOs;
using test2retake.Exceptions;
using test2retake.Services;

namespace test2retake.Controllers
{
    [Route("api/actions")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IFireDbService _service;

        public ActionController(IFireDbService service)
        {
            _service = service;
        }

        [HttpPut("{id:int}/fire-trucks")]
        public IActionResult assignFireTruck(int id ,AssignFireTruckRequest req)
        {
            try
            {
                var res = _service.assignFireTruck(id ,req);
                return Ok(res);

            }
            catch (FireTruckDoesNotExistsException ex)
            {
                return NotFound(ex.Message);
            }
            catch(OnGoingActionException ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}