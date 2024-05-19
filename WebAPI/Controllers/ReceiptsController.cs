using Business.Abstracts;
using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : ControllerBase
    {
        IReceiptService _receiptService;
        public ReceiptsController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _receiptService.GetAll();
            if (result.Success)
            {
                return Ok(result);//200 OK
            }
            return BadRequest(result);//400 Bad Request
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _receiptService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Receipt receipt)
        {
            var result = _receiptService.Add(receipt);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}