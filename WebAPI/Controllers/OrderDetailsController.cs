using Business.Abstracts;
using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailService _orderDetailService;
        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderDetailService.GetAll();
            if (result.Success)
            {
                return Ok(result);//200 OK
            }
            return BadRequest(result);//400 Bad Request
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _orderDetailService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Add(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}