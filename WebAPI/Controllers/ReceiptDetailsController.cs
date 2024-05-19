using Business.Abstracts;
using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptDetailsController : ControllerBase
    {
        IReceiptDetailService _receiptDetailService;
        public ReceiptDetailsController(IReceiptDetailService receiptDetailService)
        {
            _receiptDetailService = receiptDetailService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _receiptDetailService.GetAll();
            if (result.Success)
            {
                return Ok(result);//200 OK
            }
            return BadRequest(result);//400 Bad Request
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _receiptDetailService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ReceiptDetail receiptDetail)
        {
            var result = _receiptDetailService.Add(receiptDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}