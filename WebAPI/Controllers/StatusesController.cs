using Business.Abstracts;
using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        IStatusService _statusService;
        public StatusesController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _statusService.GetAll();
            if (result.Success)
            {
                return Ok(result);//200 OK
            }
            return BadRequest(result);//400 Bad Request
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _statusService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Status status)
        {
            var result = _statusService.Add(status);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

